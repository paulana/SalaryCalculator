"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const app_po_1 = require("./app.po");
describe('lbd-free-angularcli App', function () {
    let page;
    beforeEach(() => {
        page = new app_po_1.LbdFreeAngularcliPage();
    });
    it('should display message saying app works', () => {
        page.navigateTo();
        expect(page.getParagraphText()).toEqual('app works!');
    });
});
//# sourceMappingURL=../../../../SalaryCalculator.Web/dist/out-tsc-e2e/app.e2e-spec.js.map