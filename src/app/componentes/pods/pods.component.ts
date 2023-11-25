import { Component, Inject, inject } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-pods',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './pods.component.html',
  styleUrl: './pods.component.css'
})
export class PodsComponent {

  pods=[
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:5000,
      sabor:"TropicalRainbowBlast",
      preco:149.59
    },
    {
      marca:"Elfbar",
      puffs:5000,
      sabor:"PeachIce",
      preco:159.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },
    {
      marca:"Elfbar",
      puffs:4000,
      sabor:"StrawberryKiwi",
      preco:119.59
    },

  ]

}
