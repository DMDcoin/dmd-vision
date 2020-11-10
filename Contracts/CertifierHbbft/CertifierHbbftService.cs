using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.CertifierHbbft.ContractDefinition;

namespace DMDVision.Contracts.CertifierHbbft
{
    public partial class CertifierHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CertifierHbbftDeployment certifierHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CertifierHbbftDeployment>().SendRequestAndWaitForReceiptAsync(certifierHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CertifierHbbftDeployment certifierHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CertifierHbbftDeployment>().SendRequestAsync(certifierHbbftDeployment);
        }

        public static async Task<CertifierHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CertifierHbbftDeployment certifierHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, certifierHbbftDeployment, cancellationTokenSource);
            return new CertifierHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CertifierHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ValidatorSetContractQueryAsync(ValidatorSetContractFunction validatorSetContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(validatorSetContractFunction, blockParameter);
        }

        
        public Task<string> ValidatorSetContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(null, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(List<string> certifiedAddresses, string validatorSet)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.CertifiedAddresses = certifiedAddresses;
                initializeFunction.ValidatorSet = validatorSet;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(List<string> certifiedAddresses, string validatorSet, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.CertifiedAddresses = certifiedAddresses;
                initializeFunction.ValidatorSet = validatorSet;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> CertifyRequestAsync(CertifyFunction certifyFunction)
        {
             return ContractHandler.SendRequestAsync(certifyFunction);
        }

        public Task<TransactionReceipt> CertifyRequestAndWaitForReceiptAsync(CertifyFunction certifyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(certifyFunction, cancellationToken);
        }

        public Task<string> CertifyRequestAsync(string who)
        {
            var certifyFunction = new CertifyFunction();
                certifyFunction.Who = who;
            
             return ContractHandler.SendRequestAsync(certifyFunction);
        }

        public Task<TransactionReceipt> CertifyRequestAndWaitForReceiptAsync(string who, CancellationTokenSource cancellationToken = null)
        {
            var certifyFunction = new CertifyFunction();
                certifyFunction.Who = who;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(certifyFunction, cancellationToken);
        }

        public Task<string> RevokeRequestAsync(RevokeFunction revokeFunction)
        {
             return ContractHandler.SendRequestAsync(revokeFunction);
        }

        public Task<TransactionReceipt> RevokeRequestAndWaitForReceiptAsync(RevokeFunction revokeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeFunction, cancellationToken);
        }

        public Task<string> RevokeRequestAsync(string who)
        {
            var revokeFunction = new RevokeFunction();
                revokeFunction.Who = who;
            
             return ContractHandler.SendRequestAsync(revokeFunction);
        }

        public Task<TransactionReceipt> RevokeRequestAndWaitForReceiptAsync(string who, CancellationTokenSource cancellationToken = null)
        {
            var revokeFunction = new RevokeFunction();
                revokeFunction.Who = who;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeFunction, cancellationToken);
        }

        public Task<bool> CertifiedQueryAsync(CertifiedFunction certifiedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CertifiedFunction, bool>(certifiedFunction, blockParameter);
        }

        
        public Task<bool> CertifiedQueryAsync(string who, BlockParameter blockParameter = null)
        {
            var certifiedFunction = new CertifiedFunction();
                certifiedFunction.Who = who;
            
            return ContractHandler.QueryAsync<CertifiedFunction, bool>(certifiedFunction, blockParameter);
        }

        public Task<bool> CertifiedExplicitlyQueryAsync(CertifiedExplicitlyFunction certifiedExplicitlyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CertifiedExplicitlyFunction, bool>(certifiedExplicitlyFunction, blockParameter);
        }

        
        public Task<bool> CertifiedExplicitlyQueryAsync(string who, BlockParameter blockParameter = null)
        {
            var certifiedExplicitlyFunction = new CertifiedExplicitlyFunction();
                certifiedExplicitlyFunction.Who = who;
            
            return ContractHandler.QueryAsync<CertifiedExplicitlyFunction, bool>(certifiedExplicitlyFunction, blockParameter);
        }

        public Task<bool> IsInitializedQueryAsync(IsInitializedFunction isInitializedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(isInitializedFunction, blockParameter);
        }

        
        public Task<bool> IsInitializedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(null, blockParameter);
        }
    }
}
