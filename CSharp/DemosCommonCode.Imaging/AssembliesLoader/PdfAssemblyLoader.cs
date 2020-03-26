﻿namespace DemosCommonCode
{
    /// <summary>
    /// Loads the Vintasoft.Imaging.Pdf assembly.
    /// </summary>
    public class PdfAssemblyLoader
    {

        /// <summary>
        /// Loads the Vintasoft.Imaging.Pdf asssembly.
        /// </summary>
        public static void Load()
        {
#if !REMOVE_PDF_PLUGIN
            using (Vintasoft.Imaging.Codecs.Decoders.PdfDecoder decoder =
                new Vintasoft.Imaging.Codecs.Decoders.PdfDecoder())
            {
            }
#endif
        }
    }
}
