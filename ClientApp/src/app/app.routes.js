"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var person_phone_detail_component_1 = require("./person-phone/person-phone-detail/person-phone-detail.component");
var person_phone_component_1 = require("./person-phone/person-phone.component");
var event_detail_component_1 = require("./event/event-detail/event-detail.component");
var event_component_1 = require("./event/event.component");
var home_component_1 = require("./home/home.component");
exports.routes = [
    { path: '', component: home_component_1.HomeComponent, pathMatch: 'full' }, 
    { path: 'person-phone', component: person_phone_component_1.PersonPhoneComponent },
    { path: 'person-phone/:id', component: person_phone_detail_component_1.PersonPhoneDetailComponent },
    { path: 'person-phone', component: person_phone_detail_component_1.PersonPhoneDetailComponent },
    { path: 'events', component: event_component_1.EventComponent },
    { path: 'events/:id', component: event_detail_component_1.EventDetailComponent },
    { path: 'event', component: event_detail_component_1.EventDetailComponent }
];
exports.routing = router_1.RouterModule.forRoot(exports.routes);
//# sourceMappingURL=app.routes.js.map