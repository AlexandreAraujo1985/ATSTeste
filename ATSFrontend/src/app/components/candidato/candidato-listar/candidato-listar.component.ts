import { Candidato } from './../candidato.model';
import { CandidatoService } from './../candidato.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidato-listar',
  templateUrl: './candidato-listar.component.html',
  styleUrls: ['./candidato-listar.component.css']
})
export class CandidatoListarComponent implements OnInit {

  candidatos!: Candidato[];
  displayedColumns = ['idCandidato', 'nome', 'dataNascimento', 'profissao', 'acao']

  constructor(private candidatoService: CandidatoService) { }

  ngOnInit(): void {
    this.candidatoService.listar().subscribe(candidatos => {
      this.candidatos = candidatos
    })
  }

}
