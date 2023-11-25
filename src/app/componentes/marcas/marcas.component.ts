import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-marcas',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './marcas.component.html',
  styleUrl: './marcas.component.css'
})
export class MarcasComponent {

  marcas=[
    {
      nome:"Nikbar"
    },
    {
      nome:"Elfbar"
    },
    {
      nome:"Zomo"
    },
    {
      nome:"Ignite"
    },
    {
      nome:"Chilly"
    },
    {
      nome:"Blvk"
    }
  ]
}
