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
using DMDVision.Contracts.TxPermissionHbbft.ContractDefinition;

namespace DMDVision.Contracts.TxPermissionHbbft
{
    public partial class TxPermissionHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TxPermissionHbbftDeployment txPermissionHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TxPermissionHbbftDeployment>().SendRequestAndWaitForReceiptAsync(txPermissionHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TxPermissionHbbftDeployment txPermissionHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TxPermissionHbbftDeployment>().SendRequestAsync(txPermissionHbbftDeployment);
        }

        public static async Task<TxPermissionHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TxPermissionHbbftDeployment txPermissionHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, txPermissionHbbftDeployment, cancellationTokenSource);
            return new TxPermissionHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TxPermissionHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> BLOCK_GAS_LIMITQueryAsync(BLOCK_GAS_LIMITFunction bLOCK_GAS_LIMITFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BLOCK_GAS_LIMITFunction, BigInteger>(bLOCK_GAS_LIMITFunction, blockParameter);
        }

        
        public Task<BigInteger> BLOCK_GAS_LIMITQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BLOCK_GAS_LIMITFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> BLOCK_GAS_LIMIT_REDUCEDQueryAsync(BLOCK_GAS_LIMIT_REDUCEDFunction bLOCK_GAS_LIMIT_REDUCEDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BLOCK_GAS_LIMIT_REDUCEDFunction, BigInteger>(bLOCK_GAS_LIMIT_REDUCEDFunction, blockParameter);
        }

        
        public Task<BigInteger> BLOCK_GAS_LIMIT_REDUCEDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BLOCK_GAS_LIMIT_REDUCEDFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> CertifierContractQueryAsync(CertifierContractFunction certifierContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CertifierContractFunction, string>(certifierContractFunction, blockParameter);
        }

        
        public Task<string> CertifierContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CertifierContractFunction, string>(null, blockParameter);
        }

        public Task<bool> IsSenderAllowedQueryAsync(IsSenderAllowedFunction isSenderAllowedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsSenderAllowedFunction, bool>(isSenderAllowedFunction, blockParameter);
        }

        
        public Task<bool> IsSenderAllowedQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isSenderAllowedFunction = new IsSenderAllowedFunction();
                isSenderAllowedFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsSenderAllowedFunction, bool>(isSenderAllowedFunction, blockParameter);
        }

        public Task<string> KeyGenHistoryContractQueryAsync(KeyGenHistoryContractFunction keyGenHistoryContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<KeyGenHistoryContractFunction, string>(keyGenHistoryContractFunction, blockParameter);
        }

        
        public Task<string> KeyGenHistoryContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<KeyGenHistoryContractFunction, string>(null, blockParameter);
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

        public Task<string> InitializeRequestAsync(List<string> allowed, string certifier, string validatorSet, string keyGenHistoryContract)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.Allowed = allowed;
                initializeFunction.Certifier = certifier;
                initializeFunction.ValidatorSet = validatorSet;
                initializeFunction.KeyGenHistoryContract = keyGenHistoryContract;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(List<string> allowed, string certifier, string validatorSet, string keyGenHistoryContract, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.Allowed = allowed;
                initializeFunction.Certifier = certifier;
                initializeFunction.ValidatorSet = validatorSet;
                initializeFunction.KeyGenHistoryContract = keyGenHistoryContract;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> AddAllowedSenderRequestAsync(AddAllowedSenderFunction addAllowedSenderFunction)
        {
             return ContractHandler.SendRequestAsync(addAllowedSenderFunction);
        }

        public Task<TransactionReceipt> AddAllowedSenderRequestAndWaitForReceiptAsync(AddAllowedSenderFunction addAllowedSenderFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAllowedSenderFunction, cancellationToken);
        }

        public Task<string> AddAllowedSenderRequestAsync(string sender)
        {
            var addAllowedSenderFunction = new AddAllowedSenderFunction();
                addAllowedSenderFunction.Sender = sender;
            
             return ContractHandler.SendRequestAsync(addAllowedSenderFunction);
        }

        public Task<TransactionReceipt> AddAllowedSenderRequestAndWaitForReceiptAsync(string sender, CancellationTokenSource cancellationToken = null)
        {
            var addAllowedSenderFunction = new AddAllowedSenderFunction();
                addAllowedSenderFunction.Sender = sender;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAllowedSenderFunction, cancellationToken);
        }

        public Task<string> RemoveAllowedSenderRequestAsync(RemoveAllowedSenderFunction removeAllowedSenderFunction)
        {
             return ContractHandler.SendRequestAsync(removeAllowedSenderFunction);
        }

        public Task<TransactionReceipt> RemoveAllowedSenderRequestAndWaitForReceiptAsync(RemoveAllowedSenderFunction removeAllowedSenderFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAllowedSenderFunction, cancellationToken);
        }

        public Task<string> RemoveAllowedSenderRequestAsync(string sender)
        {
            var removeAllowedSenderFunction = new RemoveAllowedSenderFunction();
                removeAllowedSenderFunction.Sender = sender;
            
             return ContractHandler.SendRequestAsync(removeAllowedSenderFunction);
        }

        public Task<TransactionReceipt> RemoveAllowedSenderRequestAndWaitForReceiptAsync(string sender, CancellationTokenSource cancellationToken = null)
        {
            var removeAllowedSenderFunction = new RemoveAllowedSenderFunction();
                removeAllowedSenderFunction.Sender = sender;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAllowedSenderFunction, cancellationToken);
        }

        public Task<string> ContractNameQueryAsync(ContractNameFunction contractNameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractNameFunction, string>(contractNameFunction, blockParameter);
        }

        
        public Task<string> ContractNameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractNameFunction, string>(null, blockParameter);
        }

        public Task<byte[]> ContractNameHashQueryAsync(ContractNameHashFunction contractNameHashFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractNameHashFunction, byte[]>(contractNameHashFunction, blockParameter);
        }

        
        public Task<byte[]> ContractNameHashQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractNameHashFunction, byte[]>(null, blockParameter);
        }

        public Task<BigInteger> ContractVersionQueryAsync(ContractVersionFunction contractVersionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractVersionFunction, BigInteger>(contractVersionFunction, blockParameter);
        }

        
        public Task<BigInteger> ContractVersionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractVersionFunction, BigInteger>(null, blockParameter);
        }

        public Task<List<string>> AllowedSendersQueryAsync(AllowedSendersFunction allowedSendersFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AllowedSendersFunction, List<string>>(allowedSendersFunction, blockParameter);
        }

        
        public Task<List<string>> AllowedSendersQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AllowedSendersFunction, List<string>>(null, blockParameter);
        }

        public Task<AllowedTxTypesOutputDTO> AllowedTxTypesQueryAsync(AllowedTxTypesFunction allowedTxTypesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<AllowedTxTypesFunction, AllowedTxTypesOutputDTO>(allowedTxTypesFunction, blockParameter);
        }

        public Task<AllowedTxTypesOutputDTO> AllowedTxTypesQueryAsync(string sender, string to, BigInteger returnValue3, BigInteger gasPrice, byte[] data, BlockParameter blockParameter = null)
        {
            var allowedTxTypesFunction = new AllowedTxTypesFunction();
                allowedTxTypesFunction.Sender = sender;
                allowedTxTypesFunction.To = to;
                allowedTxTypesFunction.ReturnValue3 = returnValue3;
                allowedTxTypesFunction.GasPrice = gasPrice;
                allowedTxTypesFunction.Data = data;
            
            return ContractHandler.QueryDeserializingToObjectAsync<AllowedTxTypesFunction, AllowedTxTypesOutputDTO>(allowedTxTypesFunction, blockParameter);
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
