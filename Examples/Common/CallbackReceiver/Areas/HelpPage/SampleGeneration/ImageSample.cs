using System;

namespace CallbackReceiver.Areas.HelpPage
{
    /// <summary>
    /// This represents an image sample on the help page. There's a display template named ImageSample associated with this class.
    /// </summary>
    public class ImageSample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSample"/> class.
        /// </summary>
        /// <param name="src">The URL of an image.</param>
        public ImageSample(string src)
        {
            if (src == null)
            {
                throw new ArgumentNullException("src");
            }
            Src = src;
        }

        /// <summary />
        public string Src { get; private set; }

        /// <summary />
        public override bool Equals(object obj)
        {
            var other = obj as ImageSample;
            return other != null && Src == other.Src;
        }

        /// <summary />
        public override int GetHashCode()
        {
            return Src.GetHashCode();
        }

        /// <summary />
        public override string ToString()
        {
            return Src;
        }
    }
}