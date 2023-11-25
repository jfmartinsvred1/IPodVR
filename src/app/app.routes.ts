import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { MarcasComponent } from './componentes/marcas/marcas.component';
import { PodsComponent } from './componentes/pods/pods.component';
import { HomeComponent } from './componentes/home/home.component';
import { CarrinhoComponent } from './componentes/carrinho/carrinho.component';

export const routes: Routes = [
    { path: 'marcas',  component:MarcasComponent},
    { path: 'pods',  component:PodsComponent},
    { path: '',  component:HomeComponent},
    { path: 'carrinho',  component:CarrinhoComponent},

];
