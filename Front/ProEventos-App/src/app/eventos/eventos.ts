import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './eventos.html',
  styleUrl: './eventos.scss',
})
export class EventosComponent implements OnInit {
  public eventos: any[] = [];
  public eventosFiltrados: any[] = [];

  public larguraImagem = 150;
  public margemImagem = 2;
  public exibirImagem = true;

  private _filtroLista = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista
      ? this.filtrarEventos(this.filtroLista)
      : this.eventos;
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

  public alterarImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public filtrarEventos(filtrarPor: string): any[] {
    filtrarPor = filtrarPor.toLowerCase();

    return this.eventos.filter(
      evento =>
        evento.tema.toLowerCase().includes(filtrarPor) ||
        evento.local.toLowerCase().includes(filtrarPor)
    );
  }

  public getEventos(): void {
    this.http.get<any[]>('https://localhost:5001/api/eventos').subscribe({
      next: response => {
        this.eventos = response;
        this.eventosFiltrados = response;
      },
      error: error => console.log(error)
    });
  }
}


