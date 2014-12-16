
namespace Traffic.WordTemplates
{
    public interface IWordTemplate
    {
        void Fill(long id);
        void Dispose();
        Microsoft.Office.Interop.Word.Document DocWord { get; }
        string Title { get; }
    }
}
