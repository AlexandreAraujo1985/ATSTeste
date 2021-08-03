import { VagaService } from './../vaga.service';
import { Vaga } from './../vaga.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vaga-listar',
  templateUrl: './vaga-listar.component.html',
  styleUrls: ['./vaga-listar.component.css']
})
export class VagaListarComponent implements OnInit {
  vagas!: Vaga[];
  displayedColumns = ['idVaga', 'descricao', 'profissao', 'dataCriacao', 'local', 'acao']

  constructor(private vagaService: VagaService) { }

  ngOnInit(): void {
    this.vagaService.listar().subscribe(vagas => {
      this.vagas = vagas
    })
  }
}
