
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
                        SetTrace(null, NAME.STATE.TRACE.BLINK).
                        SetProgress(CONSTANT.PROGRESS.INFINITE).
                        SendPreview(NAME.EVENT.INFO, url);
                }
                {
                }
                {
                    context.
                        SetTrace(null, NAME.STATE.TRACE.NONE).
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
