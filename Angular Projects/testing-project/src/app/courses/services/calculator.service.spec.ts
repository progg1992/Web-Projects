import { TestBed } from "@angular/core/testing";
import { CalculatorService } from "./calculator.service";
import { LoggerService } from "./logger.service";

describe('CalculatorService', () => {

    let calculator: CalculatorService,
        loggerSpy: any;
    
    // runs before all tests
    beforeEach(() => {
        console.log("Calling Before Each");

        // Create fake implementation of Calc Service Dependencies
        loggerSpy = jasmine.createSpyObj('LoggerService', ["log"]);

        TestBed.configureTestingModule({
            providers: [
                CalculatorService,
                // Provide loggerSpy via Dependency Injection
                {provide: LoggerService, useValue: loggerSpy}
            ]
        })
        calculator = TestBed.get(CalculatorService);
    })

    it('should add two numbers', () => {
        console.log('Calling add test');

        const result = calculator.add(2, 2);

        expect(result).toBe(4);

        expect(loggerSpy.log).toHaveBeenCalledTimes(1);

    });

    it('should subtract two numbers', () => {
        console.log('Calling Subtract test');

        const result = calculator.subtract(2, 2);

        expect(result).toBe(0, 'unexpected subtraction result');

        expect(loggerSpy.log).toHaveBeenCalledTimes(1);

    })
})