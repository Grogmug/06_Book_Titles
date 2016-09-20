using System.Linq;
namespace _06_Book_Titles
{
    internal class Book
    {
        private string title;
        public string Title
        {
            get
            {
                title = CapitalizeEveryWord(title);
                return CapitalizeEveryWordExceptWhitelist(title);
            }
            set
            {
                title = value;
            }
        }
        public string CapitalizeFirstLetter(string title)
        {
            return title.Substring(0,1).ToUpper() + title.Substring(1);
        }

        public string CapitalizeEveryWord(string title)
        {
            string fullText = "";
            string[] eachword = title.Split(' ');

            for (int i = 0; i < eachword.Length; i++)
            {
                fullText += CapitalizeFirstLetter(eachword[i] + " ");
            }
            return fullText.Trim();
        }

        public string CapitalizeEveryWordExceptWhitelist(string title)
        {
            string[] whitelist = { "The", "A", "An", "And", "In", "Of" };
            string[] eachword = title.Split(' ');
            string fullText = "";

            for (int i = 0; i < eachword.Length; i++)
            {
                if (whitelist.Contains(eachword[i]))
                {
                    fullText += eachword[i].ToLower() + " ";
                }
                else
                {
                    fullText += eachword[i] + " ";
                }

            }
            fullText = CapitalizeFirstLetter(fullText);
            return fullText.Trim();
        }
    }


}