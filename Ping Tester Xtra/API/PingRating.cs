using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PingTesterXtra
{
    public struct PingRating
    {
        public string Text { get; private set; }
        public Color Color { get; private set; }

        public static PingRating Empty { get; private set; }
        public static PingRating Good { get; private set; }
        public static PingRating Medium { get; private set; }
        public static PingRating Bad { get; private set; }

        public static bool operator ==(PingRating left, PingRating right)
        {
            if (left == null || right == null)
            {
                return (left == null && right == null);
            }
            return (left.Text == right.Text) && (left.Color == right.Color);
        }
        public static bool operator !=(PingRating left, PingRating right)
        {
            return !(left == right);
        }

        static PingRating()
        {
            PingRating.Good = new PingRating("Good", Color.ForestGreen);
            PingRating.Medium = new PingRating("Medium", Color.Blue);
            PingRating.Bad = new PingRating("Bad", Color.Red);
            PingRating.Empty = new PingRating(string.Empty, Color.Empty);
        }

        public PingRating(string text, Color color)
            : this()
        {
            this.Text = text;
            this.Color = color;
        }

        public static PingRating FromTime(long time)
        {
            if (time <= -1)
            {
                return PingRating.Empty;
            }
            else if (time <= 100)
            {
                return PingRating.Good;
            }
            else if (time <= 300)
            {
                return PingRating.Medium;
            }
            else
            {
                return PingRating.Bad;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is PingRating)) return false;
            PingRating pingRating = (PingRating)obj;
            return pingRating.Text.Equals(this.Text) && pingRating.Color.Equals(this.Color);
        }
        public override string ToString()
        {
            return this.Text;
        }
        public override int GetHashCode()
        {
            return this.Text.GetHashCode() + this.Color.GetHashCode();
        }
    }
}
