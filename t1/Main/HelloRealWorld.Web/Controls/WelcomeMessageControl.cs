using System.Web.UI.WebControls;

namespace HelloRealWorld.Web.Controls
{
    /// <summary>
    /// Impliments CompositeControl to display the welcome message on a label.
    /// </summary>
    public class WelcomeMessageControl : CompositeControl
    {
        /// <summary>
        /// Label to contain welcome message.
        /// </summary>
        private Label label;

        /// <summary>
        /// Creates the Label control used to display the welcome message.
        /// </summary>
        protected override void CreateChildControls()
        {
            this.label = new Label();
            this.label.Text = Common.ContentManager.WelcomeMessage;
            Controls.Add(this.label);
        }
    }
}
