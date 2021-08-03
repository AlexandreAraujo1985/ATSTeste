import { VagaCandidatosComponent } from './components/vaga/vaga-candidatos/vaga-candidatos.component';
import { CandidatoVagaComponent } from './components/candidato/candidato-vaga/candidato-vaga.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from "./views/home/home.component";
import { CandidatoCrudComponent } from "./views/candidato-crud/candidato-crud.component";
import { CandidatoCriarComponent } from './components/candidato/candidato-criar/candidato-criar.component';

import { VagasCrudComponent } from './views/vagas-crud/vagas-crud.component';
import { CandidatoAlterarComponent } from './components/candidato/candidato-alterar/candidato-alterar.component';
import { CandidatoExcluirComponent } from './components/candidato/candidato-excluir/candidato-excluir.component';
import { VagaCriarComponent } from './components/vaga/vaga-criar/vaga-criar.component';
import { VagaAlterarComponent } from './components/vaga/vaga-alterar/vaga-alterar.component';
import { VagaExcluirComponent } from './components/vaga/vaga-excluir/vaga-excluir.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "candidatos",
    component: CandidatoCrudComponent
  },
  {
    path: "candidatos/criar",
    component: CandidatoCriarComponent
  },
  {
    path: "candidatos/alterar/:idCandidato",
    component: CandidatoAlterarComponent
  },
  {
    path: "candidatos/excluir/:idCandidato",
    component: CandidatoExcluirComponent
  },
  {
    path: "candidatos/cadidato-vaga/:idCandidato",
    component: CandidatoVagaComponent
  },
  {
    path: "vagas",
    component: VagasCrudComponent
  },
  {
    path: "vagas/criar",
    component: VagaCriarComponent
  },
  {
    path: "vagas/alterar/:idVaga",
    component: VagaAlterarComponent
  },
  {
    path: "vagas/excluir/:idVaga",
    component: VagaExcluirComponent
  }, 
  {
    path: "vagas/vaga-candidatos/:idVaga",
    component: VagaCandidatosComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
