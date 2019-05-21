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
const common_1 = require("@angular/common");
require("rxjs/add/operator/filter");
const router_1 = require("@angular/router");
const perfect_scrollbar_1 = require("perfect-scrollbar");
let AdminLayoutComponent = class AdminLayoutComponent {
    constructor(location, router) {
        this.location = location;
        this.router = router;
        this.yScrollStack = [];
    }
    ngOnInit() {
        console.log(this.router);
        const isWindows = navigator.platform.indexOf('Win') > -1 ? true : false;
        if (isWindows && !document.getElementsByTagName('body')[0].classList.contains('sidebar-mini')) {
            // if we are on windows OS we activate the perfectScrollbar function
            document.getElementsByTagName('body')[0].classList.add('perfect-scrollbar-on');
        }
        else {
            document.getElementsByTagName('body')[0].classList.remove('perfect-scrollbar-off');
        }
        const elemMainPanel = document.querySelector('.main-panel');
        const elemSidebar = document.querySelector('.sidebar .sidebar-wrapper');
        this.location.subscribe((ev) => {
            this.lastPoppedUrl = ev.url;
        });
        this.router.events.subscribe((event) => {
            if (event instanceof router_1.NavigationStart) {
                if (event.url != this.lastPoppedUrl)
                    this.yScrollStack.push(window.scrollY);
            }
            else if (event instanceof router_1.NavigationEnd) {
                if (event.url == this.lastPoppedUrl) {
                    this.lastPoppedUrl = undefined;
                    window.scrollTo(0, this.yScrollStack.pop());
                }
                else
                    window.scrollTo(0, 0);
            }
        });
        this._router = this.router.events.filter(event => event instanceof router_1.NavigationEnd).subscribe((event) => {
            elemMainPanel.scrollTop = 0;
            elemSidebar.scrollTop = 0;
        });
        if (window.matchMedia(`(min-width: 960px)`).matches && !this.isMac()) {
            let ps = new perfect_scrollbar_1.default(elemMainPanel);
            ps = new perfect_scrollbar_1.default(elemSidebar);
        }
    }
    ngAfterViewInit() {
        this.runOnRouteChange();
    }
    isMap(path) {
        var titlee = this.location.prepareExternalUrl(this.location.path());
        titlee = titlee.slice(1);
        if (path == titlee) {
            return false;
        }
        else {
            return true;
        }
    }
    runOnRouteChange() {
        if (window.matchMedia(`(min-width: 960px)`).matches && !this.isMac()) {
            const elemMainPanel = document.querySelector('.main-panel');
            const ps = new perfect_scrollbar_1.default(elemMainPanel);
            ps.update();
        }
    }
    isMac() {
        let bool = false;
        if (navigator.platform.toUpperCase().indexOf('MAC') >= 0 || navigator.platform.toUpperCase().indexOf('IPAD') >= 0) {
            bool = true;
        }
        return bool;
    }
};
AdminLayoutComponent = __decorate([
    core_1.Component({
        selector: 'app-admin-layout',
        templateUrl: './admin-layout.component.html',
        styleUrls: ['./admin-layout.component.scss']
    }),
    __metadata("design:paramtypes", [common_1.Location, router_1.Router])
], AdminLayoutComponent);
exports.AdminLayoutComponent = AdminLayoutComponent;
//# sourceMappingURL=../../../../../../SalaryCalculator.Web/src/app/layouts/admin-layout/admin-layout.component.js.map