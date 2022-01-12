import { Routes, RouterModule } from '@angular/router';
import { PersonPhoneComponent } from './person-phone/person-phone.component';

import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'person-phone', component: PersonPhoneComponent },
];

export const routing = RouterModule.forRoot(routes);
