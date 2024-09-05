import { Component, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.scss',
  //encapsulation: ViewEncapsulation.None  serve para aplicar os estilos em todos os componentes. (Evitar de usar)
  // encapsulation: ViewEncapsulation.ShadowDom serve para ele não receber nenhum estilo global.
})
export class CardComponent {
  displayedColumns: string[] = ['column1', 'column2', 'column3'];
  dataSource = [
    { column1: 'Data 1', column2: 'Data 2', column3: 'Data 3' },
    { column1: 'Data 4', column2: 'Data 5', column3: 'Data 6' },
    { column1: 'Data 4', column2: 'Data 5', column3: 'Data 6' },
    { column1: 'Data 4', column2: 'Data 5', column3: 'Data 6' }
  ];

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
