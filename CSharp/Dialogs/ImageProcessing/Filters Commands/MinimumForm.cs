using Vintasoft.Imaging;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.ImageProcessing.Filters;
using Vintasoft.Imaging.UI;

namespace ImagingDemo
{
	public partial class MinimumForm : OneParamConfigForm
	{

		#region Constructor

        public MinimumForm(ImageViewer viewer)
            : base(viewer, "Arithmetic.Minimum",
            new ImageProcessingParameter("Window Radius", 1, 16, 3))
        {
        }

		#endregion	



        #region Properties

        /// <summary>
        /// Gets the window size.
        /// </summary>
        public int WindowSize
        {
            get
            {
                return Parameter1 * 2 - 1;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Gets the current image processing command.
        /// </summary>
        /// <returns>Current image processing command.</returns>
        public override ProcessingCommandBase GetProcessingCommand()
        {
            return new MinimumCommand(WindowSize);
        }

        #endregion

    }
}