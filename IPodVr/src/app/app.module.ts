import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PodComponent } from './componentes/pod/pod.component';
import { HttpClientModule } from '@angular/common/http';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    PodComponent,
    CabecalhoComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
