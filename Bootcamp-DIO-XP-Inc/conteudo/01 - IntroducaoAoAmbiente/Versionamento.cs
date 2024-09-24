namespace Bootcamp_DIO_XP_Inc.conteudo;

public class Versionamento
{
/**
*   O que é Versionamento de Código?
*       O versionamento de código permite que os desenvolvedores criem ramificações (branches) para trabalhar com funcionalidades ou correções separadamente, sem interferir na versão principal do projeto. Essas ramificações são mescladas (merged) ao projeto principal quando estão prontas.
*       - Controlam as versçoes de um arquivo ao longo do tempo.
*       - Registra o histórico de atualizações de um arquivo.
*       - Gerencia quais foram as alterações, a data, autor, etc.
*       - Organização, controle e segurança.
*   
*   Tipos de Sistemas de Controle de Versão
*       - VCS Centralizado (CVCS): CVS, Subversion. Tem apenas um servidor contendo todos os arquivos. Se ficar sem sinal, não é possível colaborar.
*       - VCS Distribuído (DVCS): Git, Mercurial. Tem servidor principal e é duplicado localmente - ou clona, na máquina - possibilitando um fluxo de trabalho flexível, bem como trabalhar sem conexão à rede.
*   
*   O que é Git?
*       É um sistema de Controle de Versão Distribuído.
*       - Gratuito e Open Source (Código Aberto);
*       - Possui ramificações(branches) e fusões(merging) eficientes;
*       - Leve e rápido.
*   
*   Breve Histórico do Git
*       - 2002: O projeto do núcleo (kernel) do Linux, que é open source, começa a tilizar o BitKeeper, um DCVS proprietário;
*       - 2005: Após conflitos com a comunidade, o BitKeeper rescinde a licença gratuita. O que leva a Linus Torvalds, o criador do Linux, e sua equipe a desenvolverem sua própria ferramenta, o Git.
*        
*       Comandos: 
*           - git clone: clona um repositório Git existente para um novo diretório (pasta) local.
*           - git commit: grava alterações no repositório.
*           - git pull: "puxa" as alterações do repositório remoto para o local (busca e mescla). 
*           - git push: "empurra" as alterações do repositório local para o remoto.
*   
*   O que é GitHub?
*       Plataforma de hospedagem de código para controle de versão com Git, e colaboração.
*       - Comunidade ativa;
*       - Utilizado mundialmente;
*       - Mascote "Octocat"
*   
*   Breve histórico do GitHub:
*       - 2008: Desenvolvido por CHris Wanstrath, J. Hyettm Tom Preston-Werner e Scott Chacon.
*       - 2018: Foi vítima de um dos maiores ataques de DDOs (ataque distribuído de negação de serviços). Comprado pela Mirosoft Corporation;
*   
*   Instalando o Git no Windows
*       - Baixar em git-scm.com e instalar.
*       - 
*   
*   Configurando o Git
*       - Abrir git BASH;
*       - Alterar tema com botão direito, options;
*       - Config file location: global, system, local;
*       - git config... (visualizar opções de configurações);
*       - Ctrl+L limpa o terminal;
*       - Configurar nome e email para todos os repositórios: 
*            git config --global user.name "Jhoy"
*            git config --global user.email "jhoymartins@gmail.com"
*       - Configurar branch padrão: Para alterar git config init.defaultBranch main;
*       
*   Autenticando via Token
*       O GitHub exige o uso de token ou chaves SSH, para autenticação.
*       Este token é único, revogável, limitado e aleatório.
*       
*       Ao tentar acessar um repositório privado pelo Git Bash sem um token armazenado válido, é solicitado o acesso.
*       Para criar um token
*           - Settings -> Developer settings -> Personal access tokens -> Tokens (classic) -> configurar -> gerar token
*       Para acessar: passar usuário normal e na senha, o token.
*       Para exibir conteúdo do arquivo (.gitconfig): cat .gitconfig
*       
*       Para remover credenciais: Gerenciar credenciais do windows -> remover do github
*   
*   Autenticando via chave SSH(Secure Shell):
*       - Verificar chaves existentes: Abrir Git Bash -> ls -al ~/.ssh (para ver se as chaves SSH existentes estão presentes)
*       - Executar comando: ssh-keygen -t ed25519 -C "your_email@example.com" para criar uma chave SSH
*       - Executar comando: eval "$(ssh-agent -s)" para iniciar o ssh-agent
*       - Executar comando: ssh-add ~/.ssh/id_ed25519 adicionar sua chave SSH ao ssh-agent (inserir passphrase)
*       - Gerer SSH key: Github.com -> settings -> SSH and GPG keys -> Add new -> título com referência da máquina -> Autenticação (ou Assinatura)
*       - Acessar chave pública no /.ssh da raiz do bash: cd ~/.ssh -> ls -> cat "minha_chave.pub"
*       - Copiar chave e colar no campo Key do GitHub
*   
*   Obs: Para ir para um local desejado, ex.: Documentos/dio-git-e-github: cd ~/Documents/dio-git-e-github
*   
*   Para clonar repositório via SSH:
*       - git clone git@github.com:JhoyR/hello-world.git
*       - Se não estiver logado, inserir senha quando solicitado
*   
********************************************************************************************************************************************************
********************************************************************************************************************************************************
********************************************************************************************************************************************************
*                                                PRIMEIROS PASSOS COM GIT E GITHUB
*   
*   Criando e Clonando Repositórios
*       Existem duas formas de obter um repositório Git na sua máquina:
*           - Transformando um diretório local que não está sob controle de versão, num repositório Git;
*           - Clonando um repositório Git existente.
*   
*   No Git Bash:
*       Criar pasta/diretório para transformar no repositório git: mkdir nome_do_diretorio
*       - Executar comando: cat config (para ver o conteúdo do arquivo config e se é remoto ou local)
*       
*       Caso queira clonar um repositório, com nome da pasta diferente do repositório, digitar após a url do repositório o nome desejado
*       
*       Para conectar um repositório local a um repositório remoto: git remote add origin url_do_repositorio
*       Após isso, já constará no config do repositório o repositório remoto
*       
********************************************************************************************************************************************************
********************************************************************************************************************************************************
********************************************************************************************************************************************************
*   
*                   SALVANDO ALTERAÇÕES NO REPOSITÓRIO LOCAL
*   COMANDOS:
*       - git status: responsável por mostrar status da árvore de trabalho e da área de preparação (index/staging area)
*       Quando houver algo a ser salvo, será exibido no resultado
*       git add <arquivo_para_adicionar>: adiciona o arquivo no repositório
*       git status: para verificar se foi alterado e precisa ser atualizado
*       git commit -m "initial": realiza commit com o texto digitado descrevendo a alteração
*       git log: retorna as informações do ultimo commit realizado, autor e email, além do hash do commit (para sair, pressione 'q')
*       git status(novamente): para verificar se tudo foi enviado com sucesso
*   
*   Criar arquivo no diretório: touch pasta/arquivo.extensao
*   Ignorar arquivo ou pasta: echo diretorio > .gitignore
*   Limpar .gitignore: echo > .gitignore
*   
*   Obs.: O git não reconhece pastas ou diretórios vazios.
*   
*       .gitkeep: é para considerar um repositório vazio
*       git add . : Inserir todos os arquivos na área de preparação
*       git commit -m"texto descritivo": para realizar commit de tudo
*       git status: para verificar se a árvore de trabalho está limpa
*   
********************************************************************************************************************************************************
********************************************************************************************************************************************************
********************************************************************************************************************************************************
*                   DESFAZENDO ALTERAÇÕES NO REPOSITÓRIO LOCAL
*   
*   Caso tenha inicializado um novo repositório na pasta errada e queira remover o versionamento da mesma:
*       Comando para remover à força o diretório e seu conteúdo: rm -rf .git
*   
*   Caso precise restaurar um arquivo da árvore de trabalho:
*       Comando para restaurar: git restore nome_do_arquivo
*   
*   Caso precise corrigir a mensagem do último commit:
*       git commit --amend -m"novo texto a ser utilizado"
*       git commit --amend: abre o editor com a mensagem anterior
*   
*   Caso queira voltar o commit anterior:
*       git reset --soft <hash_do_commit>:  Pega os arquivos dos commits posteriores ao selecionado e adicionar à staging area (área de preparação).
*       git reset --mixed <hash_do_commit>: Comportamento padrão do comando reset. Adiciona à arvore de trabalho como unchecked files.
*       git reset --hard <hash_do_commit>:  Ignora completamente os arquivos do commit anterior e desfaz ele (apaga os arquivos).
*       
*       git reflog: Para um histórico mais detalhado dos commits e alterações realizados
*   
*   Caso queira remover arquivos adicionados na árvore de preparação:
*       git reset <nome_do_arquivo>
*       git restore --staged <nome_do_arquivo>
*   
********************************************************************************************************************************************************
********************************************************************************************************************************************************
********************************************************************************************************************************************************
*                   ENVIANDO E BAIXANDO ALTERAÇÕES COM O REPOSITÓRO REMOTO
*   
*   Conectar ao repositório remoto:
*       git remote add origin url_do_repositorio
*   
*   Enviar alterações do repositório local para o remoto:
*       git push -u origin main
*   
********************************************************************************************************************************************************
********************************************************************************************************************************************************
********************************************************************************************************************************************************
*                   TRABALHANDO COM BRANCHES - CRIANDO, MESCLANDO DELETANDO E TRATANDO CONFLITOS  
*   
*   De maneira simplista, uma Branch (em tradução, "Ramo") é uma ramificação do seu projeto.
*       - É um ponteiro móvel para um commit no histórico do repositório;
*       - Quando você cria uma nova Branch a partir de outra existente, a nova se inicia apontando para o mesmo commit da Branch que estava quando foi criada.
*   
*   Branches são importantes ao criar e testar novos recursos, desta forma, não colocando em risco a versão principal da aplicação.
*       - git log: visualizar para que commit a branch está apontando.
*       - Cria um novo commit: echo #commit-1-branch-main" > commit-1-branch-main.txt 
*       - Criar e alterar para branch de teste: git checkout -b teste
*       - Para voltar para a branch principal: git checout main
*       - Listar ultimo commit de cada branch: git branch -v
*   
*   Criar nova branch: git checkout -b teste-2
*   Mesclar branches com a main: git merge teste
*   Listar branches no repositório e visualizar a utilizada no momento: git branch
*   Deletar branch (teste): git branch -d teste
*   
******PESQUISAR CONVENÇÕES PARA NOMEAÇÕES DE BRANCHES E DESCRIÇÕES DE COMMITS
*   
*   
*   Conflitos de Merge
*       Os conflitos de merge ocorrem quando ocorrem alterações concorrentes. 
*       É necessário decidir quais alterações devem ser mantidas .
*       Enviar alterações para o repositório remoto: git push origin main.
*   
*   Comandos úteis no dia a dia
*       O comando 'git pull' é a junção dos comandos 'git fetch'(baixa as alterações) e 'git merge'(mescla as alterações)
*       O comando 'git diff' mostra as diferenças das branches remota e local.
*       Para trazer as alterações do repositório remoto para o local: git merge origin/main
*       O comando para clonar apenas uma branche de um repositório que contém varias branches: git clone url_do_repositorio --branch nome_da_branch --single-branch
*       Criar uma nova branch sem enviar a modificação junto (arquivar modificação): git stash
*       Listar modificações arquivadas: git stash list
*       Para trazer as alterações e excluir a altração mais recentes da pilha: git stash pop
*       Para manter as alterações na pilha para uso/modificação posterior: git stash apply
*       
*   Convenção para commits: Conventional Commits -> https://github.com/conventional-commits/conventionalcommits.org
*   
*   DICAS PARA CONTRIBUIÇÕES
*       - Encontre um projeto do seu interesse e adicione ao seu portifólio indicando a forma como contribuiu.
*       - Participe da comunidade e desenvolvam juntos;
*       - Conheça e respeite o padrão de projeto que for contribuir;
*       - Bônus: Como editar arquivos pelo GitHub. (Add File -> Create New File -> [...]) no local desejado. Ou pelo editor do github, pressionando a tecla ponto (.) para abrir o Web Editor do GitHub.
*   
*/
}
