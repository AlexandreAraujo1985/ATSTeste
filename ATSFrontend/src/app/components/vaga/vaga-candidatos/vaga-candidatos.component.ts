import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CandidatoService } from '../../candidato/candidato.service';
import { Candidato, Vaga } from '../vaga.model';
import { VagaService } from '../vaga.service';

@Component({
  selector: 'app-vaga-candidatos',
  templateUrl: './vaga-candidatos.component.html',
  styleUrls: ['./vaga-candidatos.component.css']
})
export class VagaCandidatosComponent implements OnInit {
  candidatos!: Candidato[];
  displayedColumns = ['idCandidato', 'nome', 'dataNascimento', 'profissao']

  vaga: Vaga = {
    idVaga: 0,
    descricao: '',
    profissao: '',
    dataCriacao: '',
    local: '',
    idCandidato: 0,
    candidatos: [{
      idCandidato: 0,
      nome: '',
      dataNascimento: ''
    }]
  }

  constructor(private candidatoService: CandidatoService, private vagaService: VagaService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idVaga = this.route.snapshot.paramMap.get("idVaga");

    console.log(idVaga);

    this.candidatoService.listarCadidatosVaga(idVaga).subscribe(candidatos => {
      this.candidatos = candidatos
    });

    this.vagaService.detalhar(idVaga).subscribe((vaga) => {
      this.vaga = vaga;
      this.vaga.dataCriacao = this.vaga.dataCriacao.substring(0, 10)
    });
  }

}
