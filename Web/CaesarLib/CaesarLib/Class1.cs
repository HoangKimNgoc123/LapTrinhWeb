// CaesarLib/CaesarCipher.cs
using System;
using System.Text;

namespace CaesarLib
{
    public class CaesarCipher
    {
        private string _inputText;
        private int _shift;
        private string _encodedText;
        private string _decodedText;
        private string _outputJson;

        public string InputText
        {
            get { return _inputText ?? ""; }
            set { _inputText = value ?? ""; }
        }

        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public string EncodedText
        {
            get { return _encodedText ?? ""; }
        }

        public string DecodedText
        {
            get { return _decodedText ?? ""; }
        }

        public string OutputJson
        {
            get { return _outputJson ?? ""; }
        }

        // Chính: mã hoá + giải mã và xây JSON (không ghi file, không console)
        public bool Process()
        {
            try
            {
                int s = NormalizeShift(this.Shift);
                _encodedText = Encode(this.InputText, s);
                _decodedText = Decode(_encodedText, s);
                _outputJson = BuildJson(this.InputText, s, _encodedText, _decodedText);
                return true;
            }
            catch
            {
                _encodedText = "";
                _decodedText = "";
                _outputJson = "{\"error\":\"processing error\"}";
                return false;
            }
        }

        private int NormalizeShift(int s)
        {
            // chuyển shift về 0..25
            if (s < 0)
            {
                // negative shift allowed
                s = s % 26;
                if (s < 0) s += 26;
                return s;
            }
            return s % 26;
        }

        private string Encode(string text, int s)
        {
            if (text == null) return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'A' && c <= 'Z')
                {
                    char r = (char)('A' + ((c - 'A' + s) % 26));
                    sb.Append(r);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char r = (char)('a' + ((c - 'a' + s) % 26));
                    sb.Append(r);
                }
                else
                {
                    // giữ nguyên ký tự không phải chữ
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private string Decode(string encoded, int s)
        {
            // decode = encode with 26 - s
            int back = (26 - s) % 26;
            return Encode(encoded, back);
        }

        private string BuildJson(string original, int s, string encoded, string decoded)
        {
            StringBuilder j = new StringBuilder();
            j.Append("{");
            j.Append("\"original\":\"" + EscapeForJson(original) + "\",");
            j.Append("\"shift\":" + s + ",");
            j.Append("\"encoded\":\"" + EscapeForJson(encoded) + "\",");
            j.Append("\"decoded\":\"" + EscapeForJson(decoded) + "\"");
            j.Append("}");
            return j.ToString();
        }

        private string EscapeForJson(string s)
        {
            if (s == null) return "";
            return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "").Replace("\n", "\\n");
        }
    }
}
