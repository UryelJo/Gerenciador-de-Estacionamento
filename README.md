<div align="center">
    <h1>🅿🚗🅿[== VaiDeRé.so ==]🅿🚓🅿</h2>
    <h3>Para você que tem um estacionamento e não tem o mínimo de controle sobre, apresentamos um sistema que resolvera todos os seus problemas</h4>
</div> 
<div align="center">
    desenvolvido utilizando as incriveis tecnologias de de Vue.js <img src="https://github.com/devicons/devicon/blob/master/icons/vuejs/vuejs-original.svg" width="25px"> como principal framework no Front-end
  e C# <img src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-original.svg" width="25px"> juntamente com .NET Framework no Back-End. Informações Extras:
</div>
<h2></h2>

```typescript
const programa: Informações = {

    PROGRAMADORES:[
      'Uryel jó de Lucca Araujo de Oliveira',
      'Vitor Hugo Camoleze Delantonia'
    ],

    LINGUAGENS UTILIZADAS: [
      'Typescript',
      'CSharp',
      'HTML + CSS'
    ],

    IDES UTILIZADAS:[
      'Visual Studio Code',
      'Visual Studio Community',
      'JetBrains Rider'
    ]
}
```

<div align="center">
  <h2></h2>
  <h3>⬆Diagrama de Classes⬇</h3>
  <img src="/diagrama_de_classes.drawio.png">
</div>
<br>

<div align="center">
  <h2></h2>
  <h3><img src="https://github.com/devicons/devicon/blob/master/icons/sqldeveloper/sqldeveloper-original.svg" width="25px"> Esquema do Banco de dados <img src="https://github.com/devicons/devicon/blob/master/icons/sqldeveloper/sqldeveloper-original.svg" width="25px"></h3>
</div>

```sql
CREATE TABLE public.marca (
    id INTEGER PRIMARY KEY,
    nome VARCHAR(25),
    descricao VARCHAR(50)
);

CREATE TABLE public.tipo_carro (
    id INTEGER PRIMARY KEY,
    descricao VARCHAR(50)
);

CREATE TABLE public.carro (
    id INTEGER PRIMARY KEY,
    nome VARCHAR(50),
    ano INTEGER,
    quantidade_de_portas INTEGER,
    modelo_do_motor VARCHAR(25),
    placa VARCHAR(10),
    cor VARCHAR(15),
    id_tipo_carro INTEGER,
    id_marca INTEGER,

    CONSTRAINT carro_tipo_fk FOREIGN KEY (id_tipo_carro) REFERENCES public.tipo_carro,
    CONSTRAINT carro_marca_fk FOREIGN KEY (id_marca) REFERENCES public.marca
);


CREATE TABLE public.pessoa (
    id                 INT PRIMARY KEY,
    nome               VARCHAR(50),
    cpf                VARCHAR(14),
    idade              INT
);

CREATE TABLE public.motorista (
    id                 INT PRIMARY KEY,
    id_pessoa           INT,

    CONSTRAINT motorista_pessoa_fk FOREIGN KEY (id_pessoa) REFERENCES public.pessoa(id)
);

CREATE TABLE public.guarda (
    id                 INT PRIMARY KEY,
    id_pessoa          INT,
    id_estacionamento  INT, 
    salario            FLOAT,
    horario_turno      VARCHAR(11),
    
    CONSTRAINT guarda_pessoa_fk FOREIGN KEY (id_pessoa) REFERENCES public.pessoa(id)
);

ALTER TABLE public.carro ADD id_motorista INT;
ALTER TABLE public.carro ADD CONSTRAINT carro_motorista_fk FOREIGN KEY (id_motorista)
    REFERENCES public.motorista(id);

CREATE TABLE public.endereco (
    id                 INT PRIMARY KEY,
    rua                VARCHAR(35),
    bairro             VARCHAR(35),
    cidade             VARCHAR(50),
    cep                VARCHAR(10),
    uf                 VARCHAR(2),
    numero             INT
);

CREATE TABLE public.estacionamento (
    id                 INT PRIMARY KEY,
    id_endereco        INT,
    quantidade_de_vagas_p INT,
    quantidade_de_vagas_g INT,
    
    CONSTRAINT estacionamento_endereco_fk FOREIGN KEY (id_endereco) REFERENCES public.endereco(id)
);

ALTER TABLE public.guarda ADD CONSTRAINT guarda_estacionamento_fk FOREIGN KEY (id_pessoa)
      REFERENCES public.estacionamento(id);

CREATE TABLE public.plano (
    id                 INT PRIMARY KEY,
    tempo              TIMESTAMP,
    tipo_vaga          CHAR(1)
);
CREATE TABLE public.registro (
    id                 INT PRIMARY KEY,
    id_motorista       INT,
    id_carro           INT,
    id_plano           INT,
    horario_inicio     TIME,
    horario_fim        TIME,
    
    CONSTRAINT registro_motorista_fk FOREIGN KEY (id_motorista) REFERENCES public.motorista(id),
    CONSTRAINT registro_carro_fk FOREIGN KEY (id_carro) REFERENCES public.carro(id),
    CONSTRAINT regsitro_plano_fk FOREIGN KEY (id_plano) REFERENCES public.plano(id)
);
```

