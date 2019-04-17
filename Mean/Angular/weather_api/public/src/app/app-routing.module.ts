import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TulsaComponent } from './tulsa/tulsa.component'
import { WashingtonComponent } from './washington/washington.component'
import { SeattleComponent } from './seattle/seattle.component'
import { DallasComponent } from './dallas/dallas.component'
import { ChicagoComponent } from './chicago/chicago.component'
import { BurbankComponent } from './burbank/burbank.component'

const routes: Routes = [
  { path: 'tulsa', component: TulsaComponent},
  { path: 'washington-dc', component: WashingtonComponent},
  { path: 'seattle', component: SeattleComponent},
  { path: 'dallas', component: DallasComponent},
  { path: 'chicago', component: ChicagoComponent},
  { path: 'burbank', component: BurbankComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
