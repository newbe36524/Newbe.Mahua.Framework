using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Newbe.Mahua.VsExtensions
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class NewbeCommand
    {
        public const int JoinQqGroupCommandId = 0x0100;
        public const int OpenTeachingCommandId = 0x0101;
        public const int StarCommandId = 0x0102;
        public const int MoneyCommandId = 0x0103;
        public const int QuestionCommandId = 0x0104;
        public const int AdviseCommandId = 0x0105;

        public static readonly int[] CommandIds =
        {
            JoinQqGroupCommandId,
            OpenTeachingCommandId,
            StarCommandId,
            MoneyCommandId,
            QuestionCommandId,
            AdviseCommandId,
        };

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("7cab7408-6041-45c8-a264-3caa9372bf39");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewbeCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private NewbeCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService =
                this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                foreach (var commandId in CommandIds)
                {
                    var menuCommandID = new CommandID(CommandSet, commandId);
                    var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                    commandService.AddCommand(menuItem);
                }
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static NewbeCommand Instance { get; private set; }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get { return this.package; }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new NewbeCommand(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            var menu = (MenuCommand)sender;
            switch (menu.CommandID.ID)
            {
                case JoinQqGroupCommandId:
                    Process.Start("https://jq.qq.com/?_wv=1027&k=4AMMCTx");
                    break;
                case OpenTeachingCommandId:
                    Process.Start("http://www.newbe.cf");
                    break;
                case StarCommandId:
                    Process.Start("https://github.com/Newbe36524/Newbe.Mahua.Framework/stargazers");
                    Process.Start("https://gitee.com/yks/Newbe.Mahua.Framework/stargazers");
                    break;
                case MoneyCommandId:
                    Process.Start("https://gitee.com/yks/Newbe.Mahua.Framework#project-donate-overview");
                    break;
                case AdviseCommandId:
                    Process.Start("https://gitee.com/yks/Newbe.Mahua.Framework/issues/new");
                    break;
                case QuestionCommandId:
                    Process.Start("https://gitee.com/yks/Newbe.Mahua.Framework/issues/new");
                    break;
            }
        }
    }
}
