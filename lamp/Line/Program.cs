using Octokit;
using RaGae.ArgumentLib;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RaGae.App.Lamp.Line
{
    class Program
    {
        private static Mutex mutex = new Mutex(true, nameof(Line));
        private static DirectoryInfo directory;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += OnProcess_Exit;

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Console.WriteLine(Directory.GetCurrentDirectory());
                    Argument argument = new("appsettings.json", args);

                    using (Process process = Process.GetProcessById(argument.GetValue<int>("process")))
                    {
                        if (!process.HasExited)
                            process.Kill();

                        process.WaitForExit();
                    }

                    Version version = new Version(argument.GetValue<string>("version"));
                    directory = new(argument.GetValue<string>("directory"));

                    var client = new GitHubClient(new ProductHeaderValue(argument.GetValue<string>("company")));
                    var releases = client.Repository.Release.GetAll(argument.GetValue<string>("company"), argument.GetValue<string>("repository"));

                    releases.Wait();

                    if (releases.Result is null || releases.Result.Count < 1)
                        throw new InvalidDataException(nameof(Release));

                    Version latest = new(releases?.Result[0].TagName?.Replace("v", string.Empty));

                    if (latest is not null &&
                       ((latest.Major >= version.Major && latest.Minor == version.Minor) ||
                        (latest.Major == version.Major && latest.Minor >= version.Minor)))
                    {
                        Console.WriteLine("Software ist auf dem neusten Stand!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    mutex.ReleaseMutex();

                    if (directory is not null)
                        if (directory.Exists)
                        {
                            string file = directory.GetFiles().Where(f => f.Extension == ".exe").FirstOrDefault().FullName;

                            if (!string.IsNullOrWhiteSpace(file))
                            {
                                using (Process process = new()
                                {
                                    StartInfo = new()
                                    {
                                        FileName = file,
                                        UseShellExecute = true,
                                        WindowStyle = ProcessWindowStyle.Normal,
                                        CreateNoWindow = false,
                                        WorkingDirectory = directory.FullName
                                    }
                                })
                                {
                                    try
                                    {
                                        process.Start();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                            }
                        }
                }
            }
            else
            {
                Console.WriteLine("Updater already running");
            }

            Console.Write($"{Environment.NewLine}Press any key to continue");
            Console.ReadKey();
        }

        private static void OnProcess_Exit(object sender, EventArgs e)
        {
            mutex?.ReleaseMutex();
        }
    }
}
