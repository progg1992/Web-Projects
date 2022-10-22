import { fakeAsync, flushMicrotasks, tick } from "@angular/core/testing";
import { of } from "rxjs";
import { delay } from "rxjs/operators";


describe("Async Testing Examples", () => {

    it("Async test example with Jasmine done()", (done: DoneFn) => {
        let test = false;

        setTimeout(() => {
            console.log('running assertions');

            test = true;

            expect(test).toBeTruthy()

            done()
        }, 1000);
    });

    it('Async test example - setTimeout()', fakeAsync(() => {
        let test = false;

        setTimeout(() => {
            console.log('running assertions setTimeOut');

            test = true;

            
        }, 1000);

        tick(1000);
        // Force all async operations to complete without tick by calling flush();

        expect(test).toBeTruthy()
    }));

    it('Async test example - plain promise', fakeAsync(() => {
        let test = false;

        console.log('Creating Promise');

        // setTimeout(() => {
        //     console.log('setTimeout first callback triggered')
        // });

        // setTimeout(() => {
        //     console.log('setTimeOut() second callback triggered')
        // })


        Promise.resolve().then(() => {
            console.log('Promise first then evaluated successfully');

            return Promise.resolve()
        }).then(() => {
            console.log('Promise second then() evaluated successfully');

            test = true;
        });

        flushMicrotasks();

        console.log('Running test assertions');
        expect(test).toBeTruthy();
    }));

    it('Async test example - Promises + setTimeOut()', fakeAsync(() => {
        let counter = 0;

        Promise.resolve()
            .then(() => {
                counter += 10;
                setTimeout(() => {
                    counter += 1;
                }, 1000)
            })
        expect(counter).toBe(0);

        flushMicrotasks();

        expect(counter).toBe(10);

        tick(500);

        expect(counter).toBe(10);
        
        tick(500);

        expect(counter).toBe(11)
    }));

    it('Async test example - Observable', fakeAsync(() => {
        let test = false;

        console.log('Creating Observable');

        const test$ = of(test).pipe(delay(1000));

        test$.subscribe(() => {
            test = true;
        });

        tick(1000);

        console.log('Running Assertions');
        expect(test).toBe(true);
    }))
})