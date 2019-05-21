"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const router_1 = require("@angular/router");
const common_1 = require("@angular/common");
const forms_1 = require("@angular/forms");
const lbd_module_1 = require("../../lbd/lbd.module");
const map_1 = require("@ngui/map");
const admin_layout_routing_1 = require("./admin-layout.routing");
const home_component_1 = require("../../home/home.component");
const user_component_1 = require("../../user/user.component");
const tables_component_1 = require("../../tables/tables.component");
const typography_component_1 = require("../../typography/typography.component");
const icons_component_1 = require("../../icons/icons.component");
const maps_component_1 = require("../../maps/maps.component");
const notifications_component_1 = require("../../notifications/notifications.component");
const upgrade_component_1 = require("../../upgrade/upgrade.component");
let AdminLayoutModule = class AdminLayoutModule {
};
AdminLayoutModule = __decorate([
    core_1.NgModule({
        imports: [
            common_1.CommonModule,
            router_1.RouterModule.forChild(admin_layout_routing_1.AdminLayoutRoutes),
            forms_1.FormsModule,
            lbd_module_1.LbdModule,
            map_1.NguiMapModule.forRoot({ apiUrl: 'https://maps.google.com/maps/api/js?key=YOUR_KEY_HERE' })
        ],
        declarations: [
            home_component_1.HomeComponent,
            user_component_1.UserComponent,
            tables_component_1.TablesComponent,
            typography_component_1.TypographyComponent,
            icons_component_1.IconsComponent,
            maps_component_1.MapsComponent,
            notifications_component_1.NotificationsComponent,
            upgrade_component_1.UpgradeComponent
        ]
    })
], AdminLayoutModule);
exports.AdminLayoutModule = AdminLayoutModule;
//# sourceMappingURL=../../../../../../SalaryCalculator.Web/src/app/layouts/admin-layout/admin-layout.module.js.map