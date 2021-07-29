$.ajaxSetup({timeout:2000});

$("#buttonOn").click(function() {
    relay("on");
});

$("#buttonOff").click(function() {
    relay("off");
});

$("#errorClose").click(function() {
    $("#errorMessage").addClass("d-none");
});

function relay(status) {

    var ip = $("#addonIP").val();

    if(ip == null || ip === '')
    {
        ip = "192.168.33.1";
    }

    $.get("http://" + ip + "/relay/0?turn=" + status, function(data){
        console.log(data);
      })
      .fail(function() {
        $("#errorMessage").removeClass("d-none");
      });

}