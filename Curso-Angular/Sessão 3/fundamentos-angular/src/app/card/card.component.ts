import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.scss'
})
export class CardComponent {
  plano = {
    tipo: 'Simples',
    preco: 100
  }

  getPrice() {
    return this.plano.preco * 2;
  }

  getFullPrice() {
    return 'R$' + this.plano.preco + ',00/Mês';
  }
}
