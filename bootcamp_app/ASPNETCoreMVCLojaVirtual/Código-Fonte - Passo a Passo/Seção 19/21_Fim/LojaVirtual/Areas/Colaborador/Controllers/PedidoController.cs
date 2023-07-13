﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Models;
using LojaVirtual.Models.Contants;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class PedidoController : Controller
    {
        private IPedidoRepository _pedidoRepository;
        private IPedidoSituacaoRepository _pedidoSituacaoRepository;
        private GerenciarPagarMe _gerenciarPagarMe;

        public PedidoController(IPedidoRepository pedidoRepository, IPedidoSituacaoRepository pedidoSituacaoRepository, GerenciarPagarMe gerenciarPagarMe)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoSituacaoRepository = pedidoSituacaoRepository;
            _gerenciarPagarMe = gerenciarPagarMe;
        }

        public IActionResult Index(int? pagina, string codigoPedido, string cpf)
        {
            var pedidos = _pedidoRepository.ObterTodosPedido(pagina, codigoPedido, cpf);

            return View(pedidos);
        }

        public IActionResult Visualizar(int id)
        {
            Pedido pedido = _pedidoRepository.ObterPedido(id);

            return View(pedido);
        }

        public IActionResult NFE(int id)
        {
            string url = HttpContext.Request.Form["nfe_url"];

            Pedido pedido = _pedidoRepository.ObterPedido(id);
            pedido.NFE = url;
            pedido.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

            var pedidoSituacao = new PedidoSituacao();
            pedidoSituacao.Data = DateTime.Now;
            pedidoSituacao.Dados = url;
            pedidoSituacao.PedidoId = id;
            pedidoSituacao.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

            _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);

            _pedidoRepository.Atualizar(pedido);

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }
        public IActionResult RegistrarRastreamento(int id)
        {
            string codRastreamento = HttpContext.Request.Form["cod_rastreamento"];

            Pedido pedido = _pedidoRepository.ObterPedido(id);
            pedido.FreteCodRastreamento = codRastreamento;
            pedido.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

            var pedidoSituacao = new PedidoSituacao();
            pedidoSituacao.Data = DateTime.Now;
            pedidoSituacao.Dados = codRastreamento;
            pedidoSituacao.PedidoId = id;
            pedidoSituacao.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

            _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);

            _pedidoRepository.Atualizar(pedido);

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }


        public IActionResult RegistrarCancelamentoPedidoCartaoCredito(int id)
        {
            string motivo = HttpContext.Request.Form["motivo"];

            Pedido pedido = _pedidoRepository.ObterPedido(id);
            _gerenciarPagarMe.EstornoCartaoCredito(pedido.TransactionId);

            //TODO - Salvar o Pedido e PedidoSituacao.
            //TODO - Devolver a mercadoria para o estoque.
        }
    }
}