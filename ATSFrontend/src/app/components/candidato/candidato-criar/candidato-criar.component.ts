import { Candidato } from './../candidato.model';
import { Router } from '@angular/router';
import { CandidatoService } from './../candidato.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidato-criar',
  templateUrl: './candidato-criar.component.html',
  styleUrls: ['./candidato-criar.component.css']
})
export class CandidatoCriarComponent implements OnInit {
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

  constructor(private candidatoService: CandidatoService, private router: Router) { }

  ngOnInit(): void {

  }

  removerExperiencia(index: any): void {
    this.candidato.curriculo.experiencias.splice(index, 1);
  }

  adicionarExperiencia(): void {
    this.candidato.curriculo.experiencias.push({
      idExperiencia: 0,
      nomeEmpresa: '',
      dataInicio: '',
      dataFim: ''
    });
   }

  criarCandidato(): void {
    this.candidatoService.criar(this.candidato).subscribe(() => {
      this.candidatoService.showMessage('Candidato Cadastrado!');
      this.router.navigate(['candidatos/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['candidatos/']);
  }
}
