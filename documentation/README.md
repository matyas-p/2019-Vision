# Documentation

**Module Purpose:**

From our experience with our clients, one of the challenges they have faced is being able to select multiple items at the same time in order to perform some actions like publishing or deleting.
In order to enhance Sitecore Content Editor UI, we have extended some functionalities that enables the content author to select multiple items and perform a certain action easily by providing a user-friendly feature to achieve that.

The main purpose of our module is adding a multi-selection feature for items and implementing two main functionalities in which the user can delete or publish those selected items.
In the future, we are planning to extend the multi-selection functionality to include more actions.


## Summary

**Category:** 

Best enhancement to the Sitecore Admin (XP) UI for Content Editors & Marketers

## Pre-requisites

- Sitecore 9.1 Initial Release

## Installation

- Login to your Sitecore instance, and open the Desktop. 

- On the Sitecore menu (lower left), click Development Tools, then Installation Wizard.

- Upload and browse for the following package “DynamicItemSelectionFeatures.zip”

- The following popup appears asking you if you wish to overwrite the default page under Content Manager,click yes.

**Note: We only added a reference to a custom js file in the default page.. For future releases, we are planning to change that.**

![overwrite](images/overwrite.png?raw=true "overwrite")

- You are all set now!

To make sure that you have installed your package successfully, you will be able to see the following extended features in the content editor:

- “Item Selector” checkbox under the View tab.

![ItemSelectorCheckbox](images/ItemSelectorCheckbox.png?raw=true "Item Selector Checkbox")

- “Copy-”, “Move-” and “Delete Selected Items” buttons under the Home tab.

![DeleteSelectedItems](images/CopyMoveDeleteSelectedItems.png?raw=true "Delete Selected Items Button")

- “Publish Selected Items” button under the Publish tab in the publish menu:

![PublishSelectedItems](images/PublishSelectedItems.png?raw=true "Publish Selected Items Button")

On the Files side, the following files, dlls, configurations, and JS files are installed:

1- Hackathon.Feature.DynamicCopy.dll

2- Hackathon.Feature.DynamicDelete.dll

3- Hackathon.Feature.DynamicItemSelection.dll

4- Hackathon.Feature.DynamicMove.dll

5- Hackathon.Feature.DynamicPublish.dll

6- Hackathon.Project.Site.dll

7- Overwrite to [sitecore instance]\sitecore\shell\Applications\Content Manager\Default.aspx

8- [sitecore instance]\App_Config\Include\Feature\Hackathon.Feature.DynamicCopy.config

9- [sitecore instance]\App_Config\Include\Feature\Hackathon.Feature.DynamicDelete.config

10- [sitecore instance]\App_Config\Include\Feature\Hackathon.Feature.DynamicItemsSelection.config

11- [sitecore instance]\App_Config\Include\Feature\Hackathon.Feature.DynamicMove.config

12- [sitecore instance]\App_Config\Include\Feature\Hackathon.Feature.DynamicPublish.config

13- [sitecore instance]\sitecore\shell\Applications\Content Manager\custom-multi-selection.js


## Usage

In order to be able to use our module, install the following package using Sitecore Installation Wizard: “DynamicItemSelectionFeatures_1.1.zip”.

You can start by navigating to the content editor, click on the “View tab”, and check the “Item Selector” checkbox in order to view the checkboxes next to the items in the content tree:

![ItemSelectorSelected](images/ItemSelectorSelected.png?raw=true "Item Selector Selected")

There are four main functionalities implemented:

- Copy Selected Items:

Select the items that you wish to copy, navigate to the home tab, and click on "Copy Selected Items". A content tree view appears where you can select the destination folder.

Note: If you select both an item and the parent of it, then the parent folder will be copied along with the child item, and the child item will be copied to the same level as the parent.

![CopyingSelectedItemsFunctionality](images/CopyingSelectedItemsFunctionality.png?raw=true "Copying Selected Items Functionality")

- Move Selected Items:

Select the items that you wish to move, navigate to the home tab, and click on "Move Selected Items". A content tree view appears where you can select the destination folder.

Note: If you select both an item and the parent/child of it, then it can cause unexpected outcome, e.g. the child moved first to the destination folder, and then the parent beside of the child, losing the hierarchy. That's why avoid selecting items which have parent-child relation.

![MovingSelectedItemsFunctionality](images/MovingSelectedItemsFunctionality.png?raw=true "Moving Selected Items Functionality")

- Delete Selected Items:

Select the items that you wish to delete, navigate to the home tab, and click on "Delete Selected Items", a confirmation popup appears, click on ok to delete or cancel to cancel the deletion.

Note: if you select the parent item to be deleted (i.e. Contacts), it will delete the children as well.

![DeletingSelectedItemsFunctionality](images/DeletingSelectedItemsFunctionality.png?raw=true "Deleting Selected Items Functionality")

If you click on "Delete Selected Items" without selecting any items, the following popup appears asking you to select items and retry:

![PleaseSelectItems](images/PleaseSelectItems.png?raw=true "Please Select Items")

- Publish Selected Items:

Note: Before publishing any item, make sure that this item is in the final worklow (approved).

Select the items that you wish to publish, navigate to the publish tab, and click on "Publish Selected Items" from the publish menu.

![SelectItemsToPublish](images/SelectItemsToPublish.png?raw=true "Select Items To Publish")

Once the publish is complete, the following popup appears showing the number of items processed (published):

![PublishCompletedPopup](images/PublishCompletedPopup.png?raw=true "Publish Completed Popup")

If you click on "Publish Selected Items" without selecting any items, the following popup appears asking you to select items and retry:

![PleaseSelectItemsToPublish](images/PleaseSelectItemsToPublish.png?raw=true "Please Select Items To Publish")

## Video

Following is a youtube video that explains our feature:

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/C0EEo8V9PUI/0.jpg)](https://www.youtube.com/watch?v=C0EEo8V9PUI)
