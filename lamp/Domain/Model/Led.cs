using System;

namespace RaGae.App.Lamp.Domain.Model
{
    public class Led
    {
        private int r;
        private int g;
        private int b;
        private int a;
        private int time;

        public Level Level { get; set; }

        public int R
        {
            get => this.r;
            set
            {
                if (!this.ValidateColor(value))
                    throw new ArgumentOutOfRangeException(nameof(R));

                this.r = value;
            }
        }

        public int G
        {
            get => this.g;
            set
            {
                if (!this.ValidateColor(value))
                    throw new ArgumentOutOfRangeException(nameof(G));

                this.g = value;
            }
        }

        public int B
        {
            get => this.b;
            set
            {
                if (!this.ValidateColor(value))
                    throw new ArgumentOutOfRangeException(nameof(B));

                this.b = value;
            }
        }

        public int A
        {
            get => this.a;
            set
            {
                if (!this.ValidateAlpha(value))
                    throw new ArgumentOutOfRangeException(nameof(A));

                this.a = value;
            }
        }

        public int Time
        {
            get => this.time;
            set
            {
                if (!this.ValidateTime(value))
                    throw new ArgumentOutOfRangeException(nameof(Time));

                this.time = value;
            }
        }

        private bool ValidateColor(int value)
        {
            if (value < 0 || value > 255)
                return false;
            return true;
        }

        private bool ValidateAlpha(int value)
        {
            if (value < 0 || value > 31)
                return false;
            return true;
        }

        private bool ValidateTime(int value)
        {
            if (value < 0 || value > 254)
                return false;
            return true;
        }
    }
}
