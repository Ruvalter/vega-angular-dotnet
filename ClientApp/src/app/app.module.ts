
//Modules
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

//services
import { VehicleService } from './services/vehicle.service';

//components
import { AppComponent } from './app.component';
import { CarEditComponent } from './car/car-edit/car-edit.component';
import { CounterComponent } from './counter/counter.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { VehicleFormComponent } from './components/vehicle-form/vehicle-form.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CarEditComponent,
    VehicleFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'vehicles/new', component: VehicleFormComponent },
      { path: 'home', component: HomeComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'car-edit', component: CarEditComponent },
      { path: '**', redirectTo: 'home' },
    ])
  ],
  providers: [
    HttpClientModule,
    VehicleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
