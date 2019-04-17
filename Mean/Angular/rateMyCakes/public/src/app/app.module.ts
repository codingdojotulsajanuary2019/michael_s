import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { HttpService } from './http.service'
import { FormsModule } from '@angular/forms'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddCakeComponent } from './add-cake/add-cake.component';
import { ShowCakesComponent } from './show-cakes/show-cakes.component';
import { ShowCakeComponent } from './show-cake/show-cake.component';
import { RateCakeComponent } from './rate-cake/rate-cake.component';

@NgModule({
  declarations: [
    AppComponent,
    AddCakeComponent,
    ShowCakesComponent,
    ShowCakeComponent,
    RateCakeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
  ],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
