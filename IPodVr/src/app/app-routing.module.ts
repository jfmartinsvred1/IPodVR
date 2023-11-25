import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { PodComponent } from './componentes/pod/pod.component';


const routes: Routes = [
{ path: 'pods', component: PodComponent }
];


@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule {
  
}
