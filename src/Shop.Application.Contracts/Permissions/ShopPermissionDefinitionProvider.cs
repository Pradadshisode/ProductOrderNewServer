using Shop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Shop.Permissions;

public class ShopPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ShopPermissions.GroupName, L("Permission:ProductStore"));

        myGroup.AddPermission(ShopPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(ShopPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);


        var productsPermission = myGroup.AddPermission(ShopPermissions.Products.Default, L("Permission:Products"));
        productsPermission.AddChild(ShopPermissions.Products.Create, L("Permission:Products.Create"));
        productsPermission.AddChild(ShopPermissions.Products.Edit, L("Permission:Products.Edit"));
        productsPermission.AddChild(ShopPermissions.Products.Delete, L("Permission:Products.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ShopPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShopResource>(name);
    }
}
//bookStoreGroup = myGroup
//L("Permission:ProductStore")); == L("Permission:BookStore"));
//productsPermission == booksPermission
//ShopPermissions == BookStorePermissions
//Products == Books
