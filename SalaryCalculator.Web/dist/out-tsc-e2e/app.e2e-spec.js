"use strict";
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
//# sourceMappingURL=app.e2e-spec.js.map