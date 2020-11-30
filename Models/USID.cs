using System;
using System.Collections.Generic;
using System.Linq;

namespace Sluger.Models
{
    public struct USID
    {
        private static Part Part;
        public string Slug => ToString();
        /// <summary>
        /// Default: 3
        /// </summary>
        private int SlugParts { get; set; }
        /// <summary>
        /// Not Implemented
        /// </summary>
        private int SlugLength { get; set; }
        /// <summary>
        /// Not Implemented
        /// </summary>
        private int MinSlugLength { get; set; }
        /// <summary>
        /// Not Implemented
        /// </summary>
        private int MaxSlugLength { get; set; }
        private string[] _slugs { get; set; }
        
        
        /// <summary>
        /// Set the maximum number of parts on the slug, default 3
        /// </summary>
        /// <param name="i">Number of parts</param>
        public void SetParts(int i) => SlugParts = i;
        /// <summary>
        /// Set the length of the slug parts
        /// </summary>
        /// <param name="i">Length of parts</param>
        public void SetLength(int i) => SlugLength = i;
        /// <summary>
        /// Set the minimum length of the slugs parts
        /// </summary>
        /// <param name="i">Minimum length</param>
        public void SetMinLength(int i) => MinSlugLength = i;
        /// <summary>
        /// Set the minimum length of the slugs parts
        /// </summary>
        /// <param name="i">Maximum length</param>
        public void SetMaxLength(int i) => MaxSlugLength = i;

        public override string ToString()
        {
            if (_slugs == null || !_slugs.Any()) Build();
            return String.Join('-', _slugs);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is USID))
            {
                return false;
            }
            else
            {
                var u = (USID)obj;
                return u.Slug == Slug;
            }
        }

        public USID Build()
        {
            SlugParts = SlugParts > 0 ? SlugParts : 3;
            _slugs = new string[SlugParts];
            for (int i = 0; i < SlugParts; i++)
            {
                _slugs[i] = GetPart(i+1);
            }
            return this;
        }
  
        /// <summary>
        /// Return a random word for the indicated part
        /// </summary>
        /// <param name="i">Wich part between 1 and 3</param>
        /// <returns></returns>
        private string GetPart(int i)
        {
            if(i < 1 || i > 3) throw new ArgumentException("Parameter must be between 1 and 3");
            var part = Part[i-1];
            int r = new Random().Next(0, part.Length - 1);
            return part[r].ToLower();
        }

    }
}