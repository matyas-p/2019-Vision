using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Shell.Framework;
using Sitecore.Shell.Framework.Commands;
using Sitecore.Web.UI.Sheer;
using System;
using System.Collections.Generic;
using System.Web;

namespace Hackathon.Feature.DynamicMove.Commands
{
    [Serializable]
    public class MoveSelected : MoveTo
    {
        private Database _master = Sitecore.Configuration.Factory.GetDatabase("master");
        public override void Execute(CommandContext context)
        {
            string sc_selectedItems = HttpContext.Current.Request.Cookies["sc_selectedItems"]?.Value;

            // Check if there are any items selected
            if (string.IsNullOrEmpty(sc_selectedItems))
            {
                // Show an alert to inform the user that there are no items selected
                SheerResponse.Alert("No items have been selected, please select items using the check box and then click on 'Move selected items'", Array.Empty<string>());
                return;
            }

            List<Item> itemsList = new List<Item>();
            var itemIDs = sc_selectedItems.Split(',');
            foreach (var itemID in itemIDs)
            {
                // Get selected item by id 
                Item contextItem = _master.GetItem(ID.Parse(itemID));
                itemsList.Add(contextItem);
            }

            Items.MoveTo(itemsList.ToArray());
        }

        /// <summary>
        /// Queries the state of the command.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>The state of the command.</returns>
        public override CommandState QueryState(CommandContext context)
        {
            Error.AssertObject(context, "context");
            if (context.Items.Length == 0)
            {
                return CommandState.Disabled;
            }
            Item[] items = context.Items;
            for (int i = 0; i < items.Length; i++)
            {
                Item item = items[i];
            }
            return base.QueryState(context);
        }
    }
}