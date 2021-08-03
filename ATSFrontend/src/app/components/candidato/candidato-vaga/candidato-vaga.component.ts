import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Vaga } from '../../vaga/vaga.model';
import { VagaService } from '../../vaga/vaga.service';
import { Candidato } from '../candidato.model';
import { CandidatoService } from '../candidato.service';

@Component({
  selector: 'app-candidato-vaga',
  templateUrl: './candidato-vaga.component.html',
  styleUrls: ['./candidato-vaga.component.css']
})
export class CandidatoVagaComponent implements OnInit {
  candidato: Candidato = {
    idCandidato: 0,
    nome: '',
    profissao: '',
    ativo: true,
    dataNascimento: '',
    curriculo: {
      idCurriculo: 0,
      idCandidato: 0,
      idExperiencia: 0,
      formacaoAcademica: '',
      experiencias: [{
        idExperiencia: 0,
        nomeEmpresa: '',
        dataInicio: '',
        dataFim: ''
      }]
    },
  };

  vagas!: Vaga[];
  displayedColumns = ['idVaga', 'descricao', 'profissao', 'dataCriacao', 'local', 'acao']

  constructor(private candidatoService: CandidatoService, private vagaService: VagaService, 
  private router: Router , private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idCandidato = this.route.snapshot.paramMap.get("idCandidato");
    this.candidatoService.detalhar(idCandidato).subscribe((candidato) => {
      this.candidato = candidato;
      this.candidato.dataNascimento = this.candidato.dataNascimento.substring(0, 10)
    });

    this.vagaService.listar().subscribe(vagas => {
      this.vagas = vagas
    })
  }

  candidatarSe(idVaga: any): void {
    this.candidato.idVaga = idVaga;
    this.candidatoService.alterar(this.candidato).subscribe(() => {
      this.candidatoService.showMessage('Cantidatura realizada!');
      this.router.navigate(['candidatos/']);
    });
  }
}
