import { Candidato } from './../candidato.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CandidatoService } from '../candidato.service';

@Component({
  selector: 'app-candidato-alterar',
  templateUrl: './candidato-alterar.component.html',
  styleUrls: ['./candidato-alterar.component.css']
})
export class CandidatoAlterarComponent implements OnInit {

  candidato: Candidato = {
    idCandidato: 0,
    nome: '',
    ativo: true,
    profissao: '',
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

  constructor(private candidatoService: CandidatoService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idCandidato = this.route.snapshot.paramMap.get("idCandidato");
    this.candidatoService.detalhar(idCandidato).subscribe((candidato) => {
      this.candidato = candidato;
      this.candidato.dataNascimento = this.candidato.dataNascimento.substring(0, 10)
      if (candidato.curriculo) {
        if (candidato.curriculo.experiencias.length > 0) {
          candidato.curriculo.experiencias.forEach(element => {
            element.dataInicio = element.dataInicio.substring(0, 10)
            element.dataFim = element.dataFim.substring(0, 10)
          });
        }
      }
    });
  }

  removerExperiencia(index: any): void {
    console.log(index);
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

  alterarCandidato(): void {
    this.candidatoService.alterar(this.candidato).subscribe(() => {
      this.candidatoService.showMessage('Candidato Alterado!');
      this.router.navigate(['candidatos/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['candidatos/']);
  }
}

