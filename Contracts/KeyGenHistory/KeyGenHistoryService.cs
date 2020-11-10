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
using DMDVision.Contracts.KeyGenHistory.ContractDefinition;

namespace DMDVision.Contracts.KeyGenHistory
{
    public partial class KeyGenHistoryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, KeyGenHistoryDeployment keyGenHistoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<KeyGenHistoryDeployment>().SendRequestAndWaitForReceiptAsync(keyGenHistoryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, KeyGenHistoryDeployment keyGenHistoryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<KeyGenHistoryDeployment>().SendRequestAsync(keyGenHistoryDeployment);
        }

        public static async Task<KeyGenHistoryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, KeyGenHistoryDeployment keyGenHistoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, keyGenHistoryDeployment, cancellationTokenSource);
            return new KeyGenHistoryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public KeyGenHistoryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<byte[]> AcksQueryAsync(AcksFunction acksFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AcksFunction, byte[]>(acksFunction, blockParameter);
        }

        
        public Task<byte[]> AcksQueryAsync(string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null)
        {
            var acksFunction = new AcksFunction();
                acksFunction.ReturnValue1 = returnValue1;
                acksFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<AcksFunction, byte[]>(acksFunction, blockParameter);
        }

        public Task<byte[]> PartsQueryAsync(PartsFunction partsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PartsFunction, byte[]>(partsFunction, blockParameter);
        }

        
        public Task<byte[]> PartsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var partsFunction = new PartsFunction();
                partsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PartsFunction, byte[]>(partsFunction, blockParameter);
        }

        public Task<string> ValidatorSetQueryAsync(ValidatorSetFunction validatorSetFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetFunction, string>(validatorSetFunction, blockParameter);
        }

        
        public Task<string> ValidatorSetQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var validatorSetFunction = new ValidatorSetFunction();
                validatorSetFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ValidatorSetFunction, string>(validatorSetFunction, blockParameter);
        }

        public Task<string> ValidatorSetContractQueryAsync(ValidatorSetContractFunction validatorSetContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(validatorSetContractFunction, blockParameter);
        }

        
        public Task<string> ValidatorSetContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(null, blockParameter);
        }

        public Task<string> ClearPrevKeyGenStateRequestAsync(ClearPrevKeyGenStateFunction clearPrevKeyGenStateFunction)
        {
             return ContractHandler.SendRequestAsync(clearPrevKeyGenStateFunction);
        }

        public Task<TransactionReceipt> ClearPrevKeyGenStateRequestAndWaitForReceiptAsync(ClearPrevKeyGenStateFunction clearPrevKeyGenStateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(clearPrevKeyGenStateFunction, cancellationToken);
        }

        public Task<string> ClearPrevKeyGenStateRequestAsync(List<string> prevValidators)
        {
            var clearPrevKeyGenStateFunction = new ClearPrevKeyGenStateFunction();
                clearPrevKeyGenStateFunction.PrevValidators = prevValidators;
            
             return ContractHandler.SendRequestAsync(clearPrevKeyGenStateFunction);
        }

        public Task<TransactionReceipt> ClearPrevKeyGenStateRequestAndWaitForReceiptAsync(List<string> prevValidators, CancellationTokenSource cancellationToken = null)
        {
            var clearPrevKeyGenStateFunction = new ClearPrevKeyGenStateFunction();
                clearPrevKeyGenStateFunction.PrevValidators = prevValidators;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(clearPrevKeyGenStateFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string validatorSetContract, List<string> validators, List<byte[]> parts, List<List<byte[]>> acks)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSetContract = validatorSetContract;
                initializeFunction.Validators = validators;
                initializeFunction.Parts = parts;
                initializeFunction.Acks = acks;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string validatorSetContract, List<string> validators, List<byte[]> parts, List<List<byte[]>> acks, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSetContract = validatorSetContract;
                initializeFunction.Validators = validators;
                initializeFunction.Parts = parts;
                initializeFunction.Acks = acks;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> WritePartRequestAsync(WritePartFunction writePartFunction)
        {
             return ContractHandler.SendRequestAsync(writePartFunction);
        }

        public Task<TransactionReceipt> WritePartRequestAndWaitForReceiptAsync(WritePartFunction writePartFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(writePartFunction, cancellationToken);
        }

        public Task<string> WritePartRequestAsync(byte[] part)
        {
            var writePartFunction = new WritePartFunction();
                writePartFunction.Part = part;
            
             return ContractHandler.SendRequestAsync(writePartFunction);
        }

        public Task<TransactionReceipt> WritePartRequestAndWaitForReceiptAsync(byte[] part, CancellationTokenSource cancellationToken = null)
        {
            var writePartFunction = new WritePartFunction();
                writePartFunction.Part = part;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(writePartFunction, cancellationToken);
        }

        public Task<string> WriteAckRequestAsync(WriteAckFunction writeAckFunction)
        {
             return ContractHandler.SendRequestAsync(writeAckFunction);
        }

        public Task<TransactionReceipt> WriteAckRequestAndWaitForReceiptAsync(WriteAckFunction writeAckFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(writeAckFunction, cancellationToken);
        }

        public Task<string> WriteAckRequestAsync(byte[] ack)
        {
            var writeAckFunction = new WriteAckFunction();
                writeAckFunction.Ack = ack;
            
             return ContractHandler.SendRequestAsync(writeAckFunction);
        }

        public Task<TransactionReceipt> WriteAckRequestAndWaitForReceiptAsync(byte[] ack, CancellationTokenSource cancellationToken = null)
        {
            var writeAckFunction = new WriteAckFunction();
                writeAckFunction.Ack = ack;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(writeAckFunction, cancellationToken);
        }

        public Task<BigInteger> GetAcksLengthQueryAsync(GetAcksLengthFunction getAcksLengthFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAcksLengthFunction, BigInteger>(getAcksLengthFunction, blockParameter);
        }

        
        public Task<BigInteger> GetAcksLengthQueryAsync(string val, BlockParameter blockParameter = null)
        {
            var getAcksLengthFunction = new GetAcksLengthFunction();
                getAcksLengthFunction.Val = val;
            
            return ContractHandler.QueryAsync<GetAcksLengthFunction, BigInteger>(getAcksLengthFunction, blockParameter);
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
