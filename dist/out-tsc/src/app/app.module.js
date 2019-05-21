"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const animations_1 = require("@angular/platform-browser/animations");
const core_1 = require("@angular/core");
const forms_1 = require("@angular/forms");
const http_1 = require("@angular/common/http");
const router_1 = require("@angular/router");
const app_routing_1 = require("./app.routing");
const navbar_module_1 = require("./shared/navbar/navbar.module");
const footer_module_1 = require("./shared/footer/footer.module");
const sidebar_module_1 = require("./sidebar/sidebar.module");
const app_component_1 = require("./app.component");
const admin_layout_component_1 = require("./layouts/admin-layout/admin-layout.component");
let AppModule = class AppModule {
};
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            animations_1.BrowserAnimationsModule,
            forms_1.FormsModule,
            router_1.RouterModule,
            http_1.HttpClientModule,
            navbar_module_1.NavbarModule,
            footer_module_1.FooterModule,
            sidebar_module_1.SidebarModule,
            app_routing_1.AppRoutingModule
        ],
        declarations: [
            app_component_1.AppComponent,
            admin_layout_component_1.AdminLayoutComponent
        ],
        providers: [],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=../../../../SalaryCalculator.Web/src/app/app.module.js.map