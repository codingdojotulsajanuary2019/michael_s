import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component'
import { NewAuthorComponent } from './new-author/new-author.component'
import { EditAuthorComponent } from './edit-author/edit-author.component'

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'new', component: NewAuthorComponent},
  {path: 'edit/:id', component: EditAuthorComponent},
  {path: '', pathMatch:'full', redirectTo: '/home'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
