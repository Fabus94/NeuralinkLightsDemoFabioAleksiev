var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TimerControlLightsTestComponent } from './timerControl-lightsTest.component';
import { SharedModule } from '../shared/shared.module';
import { LightsTest } from './lightsTest.component';
import { TransitionLightsTestComponent } from './transition-lightsTest.component';
var LightsModule = /** @class */ (function () {
    function LightsModule() {
    }
    LightsModule = __decorate([
        NgModule({
            imports: [
                SharedModule,
                RouterModule.forChild([
                    {
                        path: 'lights',
                        component: LightsTest
                    }
                ])
            ],
            declarations: [
                LightsTest,
                TimerControlLightsTestComponent,
                TransitionLightsTestComponent
            ]
        })
    ], LightsModule);
    return LightsModule;
}());
export { LightsModule };
//# sourceMappingURL=lights.module.js.map