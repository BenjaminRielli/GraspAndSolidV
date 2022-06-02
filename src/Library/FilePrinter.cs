using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextToPrint igetTextToPrint)
        {
            File.WriteAllText("Recipe.txt", igetTextToPrint.GetTextToPrint());
        }
    }
}