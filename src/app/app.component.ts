import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { RodapeComponent } from "./componentes/rodape/rodape.component";
import { HomeComponent } from './componentes/home/home.component';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [
        CommonModule,
        RouterOutlet,
        CabecalhoComponent,
        RodapeComponent,
        HomeComponent
    ]
})
export class AppComponent {
  title = 'IpodDeliveryVR';
}
