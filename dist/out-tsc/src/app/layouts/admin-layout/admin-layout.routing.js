"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const home_component_1 = require("../../home/home.component");
const user_component_1 = require("../../user/user.component");
const tables_component_1 = require("../../tables/tables.component");
const typography_component_1 = require("../../typography/typography.component");
const icons_component_1 = require("../../icons/icons.component");
const maps_component_1 = require("../../maps/maps.component");
const notifications_component_1 = require("../../notifications/notifications.component");
const upgrade_component_1 = require("../../upgrade/upgrade.component");
exports.AdminLayoutRoutes = [
    { path: 'dashboard', component: home_component_1.HomeComponent },
    { path: 'user', component: user_component_1.UserComponent },
    { path: 'table', component: tables_component_1.TablesComponent },
    { path: 'typography', component: typography_component_1.TypographyComponent },
    { path: 'icons', component: icons_component_1.IconsComponent },
    { path: 'maps', component: maps_component_1.MapsComponent },
    { path: 'notifications', component: notifications_component_1.NotificationsComponent },
    { path: 'upgrade', component: upgrade_component_1.UpgradeComponent },
];
//# sourceMappingURL=../../../../../../SalaryCalculator.Web/src/app/layouts/admin-layout/admin-layout.routing.js.map