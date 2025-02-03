using System.Xml.Linq;

namespace testRep
{
    internal class FontSize
    {
        public string _fontSize, _fontName;
        private string fontSize { get => _fontSize; set => _fontSize = value; }
        private string fontName { get => _fontName; set => _fontName = value; }
        public FontSize(string name, string size)
        {
            _fontName = name;
            _fontSize = size;
        } 

        public override string ToString()
        {
            return $"{fontName}";
        }
        public string ToString2()
        {
            return $"{fontSize}";
        }
    }
}