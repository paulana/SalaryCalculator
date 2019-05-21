import { LbdFreeAngularcliPage } from './app.po';

describe('lbd-free-angularcli App', function() {
  let page: LbdFreeAngularcliPage;

  beforeEach(() => {
    page = new LbdFreeAngularcliPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect<any>(page.getParagraphText()).toEqual('app works!');
  });
});
