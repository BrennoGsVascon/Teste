import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.html',
  imports: [CommonModule],
  styleUrl: './eventos.scss',
})
export class Eventos {
  eventos = [
    'Angular' ,
    'React' ,
    'Vue'
  ];
}
