
namespace resource.preview
{
    internal class VSPreview : extension.AnyPreview
    {
        protected override void _Execute(atom.Trace context, int level, string url, string file)
        {
            var a_Context = new NuGet.Packaging.PackageArchiveReader(url);
            //if (PeFile.TryParse(file, out a_Context))
            {
                {
                    context.
                        SetFontState(NAME.FONT_STATE.BLINK).
                        SetProgress(NAME.PROGRESS.INFINITE).
                        SendPreview(NAME.EVENT.INFO, url);
                }
                {
                }
                {
                    context.
                        SetFontState(NAME.FONT_STATE.NONE).
                        SetProgress(100).
                        SendPreview(NAME.EVENT.INFO, url);
                }
            }
            //else
            {
                //context.
                //    SetUrl(url).
                //    Send(NAME.SOURCE.PREVIEW, NAME.EVENT.ERROR, level, GetFinalText(name), GetFinalText(value));
            }
        }
    };
}
