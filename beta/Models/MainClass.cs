using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace beta.Models
{
    public class Start
    {
        public int Lang { get; set; }
    }
    public class Image
    {
        public string Title { get; set; }
        public string Abrev { get; set; }
        public string Length { get; set; }
    }
    public class Info
    {
        public int Number { get; set; }
        public int Lang { get; set; }
        public string Text { get; set; }
    }
    public class Painting
    {
        public string Title { get; set; }
        public string Technique { get; set; }
        public int Availability { get; set; }
        public string Abrev { get; set; }
        public string Size { get; set; }
    }
    public class SubClass
    {
        public int Lang { get; set; }
        public int Count { get; set; }
        public string Abrev { get; set; }
        public int Family { get; set; }
    }
}