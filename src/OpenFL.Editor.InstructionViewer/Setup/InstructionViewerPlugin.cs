using OpenFL.Editor.InstructionViewer.Forms;
using OpenFL.Editor.Utils.Plugins;

using PluginSystem.Utility;

namespace OpenFL.Editor.InstructionViewer.Setup
{
    public class InstructionViewerPlugin : APlugin<FLEditorPluginHost>
    {

        public override string Name => "fl-editor-instruction-viewer";

        private InstructionViewerForm f;

        [ToolbarItem("FL", 2)]
        private void FLDummy()
        {
        }

        [ToolbarItem("FL/View Instructions", 0)]
        private void OnViewerOpen()
        {
            if (f == null || f.IsDisposed)
            {
                f = new InstructionViewerForm(PluginHost.Editor.FLContainer.InstructionSet);
                f.Show();
            }
        }

    }
}