"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
exports.ROUTES = [
    { path: '/dashboard', title: 'Dashboard', icon: 'pe-7s-graph', class: '' },
    { path: '/user', title: 'User Profile', icon: 'pe-7s-user', class: '' },
    { path: '/table', title: 'Table List', icon: 'pe-7s-note2', class: '' },
    { path: '/typography', title: 'Typography', icon: 'pe-7s-news-paper', class: '' },
    { path: '/icons', title: 'Icons', icon: 'pe-7s-science', class: '' },
    { path: '/maps', title: 'Maps', icon: 'pe-7s-map-marker', class: '' },
    { path: '/notifications', title: 'Notifications', icon: 'pe-7s-bell', class: '' },
    { path: '/upgrade', title: 'Upgrade to PRO', icon: 'pe-7s-rocket', class: 'active-pro' },
];
let SidebarComponent = class SidebarComponent {
    constructor() { }
    ngOnInit() {
        this.menuItems = exports.ROUTES.filter(menuItem => menuItem);
    }
    isMobileMenu() {
        if ($(window).width() > 991) {
            return false;
        }
        return true;
    }
    ;
};
SidebarComponent = __decorate([
    core_1.Component({
        selector: 'app-sidebar',
        templateUrl: './sidebar.component.html'
    }),
    __metadata("design:paramtypes", [])
], SidebarComponent);
exports.SidebarComponent = SidebarComponent;
//# sourceMappingURL=../../../../../SalaryCalculator.Web/src/app/sidebar/sidebar.component.js.map