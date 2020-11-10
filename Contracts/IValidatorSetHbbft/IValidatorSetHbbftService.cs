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
using DMDVision.Contracts.IValidatorSetHbbft.ContractDefinition;

namespace DMDVision.Contracts.IValidatorSetHbbft
{
    public partial class IValidatorSetHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IValidatorSetHbbftDeployment iValidatorSetHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IValidatorSetHbbftDeployment>().SendRequestAndWaitForReceiptAsync(iValidatorSetHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IValidatorSetHbbftDeployment iValidatorSetHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IValidatorSetHbbftDeployment>().SendRequestAsync(iValidatorSetHbbftDeployment);
        }

        public static async Task<IValidatorSetHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IValidatorSetHbbftDeployment iValidatorSetHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iValidatorSetHbbftDeployment, cancellationTokenSource);
            return new IValidatorSetHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IValidatorSetHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string returnValue1, string returnValue2, string returnValue3, string returnValue4, List<string> returnValue5, List<string> returnValue6)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
                initializeFunction.ReturnValue5 = returnValue5;
                initializeFunction.ReturnValue6 = returnValue6;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, string returnValue3, string returnValue4, List<string> returnValue5, List<string> returnValue6, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
                initializeFunction.ReturnValue5 = returnValue5;
                initializeFunction.ReturnValue6 = returnValue6;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> FinalizeChangeRequestAsync(FinalizeChangeFunction finalizeChangeFunction)
        {
             return ContractHandler.SendRequestAsync(finalizeChangeFunction);
        }

        public Task<string> FinalizeChangeRequestAsync()
        {
             return ContractHandler.SendRequestAsync<FinalizeChangeFunction>();
        }

        public Task<TransactionReceipt> FinalizeChangeRequestAndWaitForReceiptAsync(FinalizeChangeFunction finalizeChangeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeChangeFunction, cancellationToken);
        }

        public Task<TransactionReceipt> FinalizeChangeRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<FinalizeChangeFunction>(null, cancellationToken);
        }

        public Task<string> NewValidatorSetRequestAsync(NewValidatorSetFunction newValidatorSetFunction)
        {
             return ContractHandler.SendRequestAsync(newValidatorSetFunction);
        }

        public Task<string> NewValidatorSetRequestAsync()
        {
             return ContractHandler.SendRequestAsync<NewValidatorSetFunction>();
        }

        public Task<TransactionReceipt> NewValidatorSetRequestAndWaitForReceiptAsync(NewValidatorSetFunction newValidatorSetFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(newValidatorSetFunction, cancellationToken);
        }

        public Task<TransactionReceipt> NewValidatorSetRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<NewValidatorSetFunction>(null, cancellationToken);
        }

        public Task<string> RemoveMaliciousValidatorsRequestAsync(RemoveMaliciousValidatorsFunction removeMaliciousValidatorsFunction)
        {
             return ContractHandler.SendRequestAsync(removeMaliciousValidatorsFunction);
        }

        public Task<TransactionReceipt> RemoveMaliciousValidatorsRequestAndWaitForReceiptAsync(RemoveMaliciousValidatorsFunction removeMaliciousValidatorsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeMaliciousValidatorsFunction, cancellationToken);
        }

        public Task<string> RemoveMaliciousValidatorsRequestAsync(List<string> returnValue1)
        {
            var removeMaliciousValidatorsFunction = new RemoveMaliciousValidatorsFunction();
                removeMaliciousValidatorsFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(removeMaliciousValidatorsFunction);
        }

        public Task<TransactionReceipt> RemoveMaliciousValidatorsRequestAndWaitForReceiptAsync(List<string> returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var removeMaliciousValidatorsFunction = new RemoveMaliciousValidatorsFunction();
                removeMaliciousValidatorsFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeMaliciousValidatorsFunction, cancellationToken);
        }

        public Task<string> SetStakingAddressRequestAsync(SetStakingAddressFunction setStakingAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setStakingAddressFunction);
        }

        public Task<TransactionReceipt> SetStakingAddressRequestAndWaitForReceiptAsync(SetStakingAddressFunction setStakingAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingAddressFunction, cancellationToken);
        }

        public Task<string> SetStakingAddressRequestAsync(string returnValue1, string returnValue2)
        {
            var setStakingAddressFunction = new SetStakingAddressFunction();
                setStakingAddressFunction.ReturnValue1 = returnValue1;
                setStakingAddressFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(setStakingAddressFunction);
        }

        public Task<TransactionReceipt> SetStakingAddressRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var setStakingAddressFunction = new SetStakingAddressFunction();
                setStakingAddressFunction.ReturnValue1 = returnValue1;
                setStakingAddressFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingAddressFunction, cancellationToken);
        }

        public Task<bool> AreDelegatorsBannedQueryAsync(AreDelegatorsBannedFunction areDelegatorsBannedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AreDelegatorsBannedFunction, bool>(areDelegatorsBannedFunction, blockParameter);
        }

        
        public Task<bool> AreDelegatorsBannedQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var areDelegatorsBannedFunction = new AreDelegatorsBannedFunction();
                areDelegatorsBannedFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<AreDelegatorsBannedFunction, bool>(areDelegatorsBannedFunction, blockParameter);
        }

        public Task<string> BlockRewardContractQueryAsync(BlockRewardContractFunction blockRewardContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BlockRewardContractFunction, string>(blockRewardContractFunction, blockParameter);
        }

        
        public Task<string> BlockRewardContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BlockRewardContractFunction, string>(null, blockParameter);
        }

        public Task<List<string>> GetPendingValidatorsQueryAsync(GetPendingValidatorsFunction getPendingValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPendingValidatorsFunction, List<string>>(getPendingValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetPendingValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPendingValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetPreviousValidatorsQueryAsync(GetPreviousValidatorsFunction getPreviousValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPreviousValidatorsFunction, List<string>>(getPreviousValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetPreviousValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPreviousValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetValidatorsQueryAsync(GetValidatorsFunction getValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorsFunction, List<string>>(getValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<bool> IsReportValidatorValidQueryAsync(IsReportValidatorValidFunction isReportValidatorValidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsReportValidatorValidFunction, bool>(isReportValidatorValidFunction, blockParameter);
        }

        
        public Task<bool> IsReportValidatorValidQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isReportValidatorValidFunction = new IsReportValidatorValidFunction();
                isReportValidatorValidFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsReportValidatorValidFunction, bool>(isReportValidatorValidFunction, blockParameter);
        }

        public Task<bool> IsValidatorQueryAsync(IsValidatorFunction isValidatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorFunction, bool>(isValidatorFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isValidatorFunction = new IsValidatorFunction();
                isValidatorFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsValidatorFunction, bool>(isValidatorFunction, blockParameter);
        }

        public Task<bool> IsValidatorBannedQueryAsync(IsValidatorBannedFunction isValidatorBannedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorBannedFunction, bool>(isValidatorBannedFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorBannedQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isValidatorBannedFunction = new IsValidatorBannedFunction();
                isValidatorBannedFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsValidatorBannedFunction, bool>(isValidatorBannedFunction, blockParameter);
        }

        public Task<bool> IsValidatorOrPendingQueryAsync(IsValidatorOrPendingFunction isValidatorOrPendingFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorOrPendingFunction, bool>(isValidatorOrPendingFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorOrPendingQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isValidatorOrPendingFunction = new IsValidatorOrPendingFunction();
                isValidatorOrPendingFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsValidatorOrPendingFunction, bool>(isValidatorOrPendingFunction, blockParameter);
        }

        public Task<bool> IsPendingValidatorQueryAsync(IsPendingValidatorFunction isPendingValidatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPendingValidatorFunction, bool>(isPendingValidatorFunction, blockParameter);
        }

        
        public Task<bool> IsPendingValidatorQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isPendingValidatorFunction = new IsPendingValidatorFunction();
                isPendingValidatorFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsPendingValidatorFunction, bool>(isPendingValidatorFunction, blockParameter);
        }

        public Task<BigInteger> MAX_VALIDATORSQueryAsync(MAX_VALIDATORSFunction mAX_VALIDATORSFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_VALIDATORSFunction, BigInteger>(mAX_VALIDATORSFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_VALIDATORSQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_VALIDATORSFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> MiningByStakingAddressQueryAsync(MiningByStakingAddressFunction miningByStakingAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MiningByStakingAddressFunction, string>(miningByStakingAddressFunction, blockParameter);
        }

        
        public Task<string> MiningByStakingAddressQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var miningByStakingAddressFunction = new MiningByStakingAddressFunction();
                miningByStakingAddressFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<MiningByStakingAddressFunction, string>(miningByStakingAddressFunction, blockParameter);
        }

        public Task<string> RandomContractQueryAsync(RandomContractFunction randomContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RandomContractFunction, string>(randomContractFunction, blockParameter);
        }

        
        public Task<string> RandomContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RandomContractFunction, string>(null, blockParameter);
        }

        public Task<ReportMaliciousCallableOutputDTO> ReportMaliciousCallableQueryAsync(ReportMaliciousCallableFunction reportMaliciousCallableFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<ReportMaliciousCallableFunction, ReportMaliciousCallableOutputDTO>(reportMaliciousCallableFunction, blockParameter);
        }

        public Task<ReportMaliciousCallableOutputDTO> ReportMaliciousCallableQueryAsync(string returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null)
        {
            var reportMaliciousCallableFunction = new ReportMaliciousCallableFunction();
                reportMaliciousCallableFunction.ReturnValue1 = returnValue1;
                reportMaliciousCallableFunction.ReturnValue2 = returnValue2;
                reportMaliciousCallableFunction.ReturnValue3 = returnValue3;
            
            return ContractHandler.QueryDeserializingToObjectAsync<ReportMaliciousCallableFunction, ReportMaliciousCallableOutputDTO>(reportMaliciousCallableFunction, blockParameter);
        }

        public Task<string> StakingByMiningAddressQueryAsync(StakingByMiningAddressFunction stakingByMiningAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingByMiningAddressFunction, string>(stakingByMiningAddressFunction, blockParameter);
        }

        
        public Task<string> StakingByMiningAddressQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var stakingByMiningAddressFunction = new StakingByMiningAddressFunction();
                stakingByMiningAddressFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<StakingByMiningAddressFunction, string>(stakingByMiningAddressFunction, blockParameter);
        }

        public Task<byte[]> PublicKeyByStakingAddressQueryAsync(PublicKeyByStakingAddressFunction publicKeyByStakingAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PublicKeyByStakingAddressFunction, byte[]>(publicKeyByStakingAddressFunction, blockParameter);
        }

        
        public Task<byte[]> PublicKeyByStakingAddressQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var publicKeyByStakingAddressFunction = new PublicKeyByStakingAddressFunction();
                publicKeyByStakingAddressFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PublicKeyByStakingAddressFunction, byte[]>(publicKeyByStakingAddressFunction, blockParameter);
        }

        public Task<byte[]> GetPublicKeyQueryAsync(GetPublicKeyFunction getPublicKeyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPublicKeyFunction, byte[]>(getPublicKeyFunction, blockParameter);
        }

        
        public Task<byte[]> GetPublicKeyQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var getPublicKeyFunction = new GetPublicKeyFunction();
                getPublicKeyFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<GetPublicKeyFunction, byte[]>(getPublicKeyFunction, blockParameter);
        }

        public Task<string> StakingContractQueryAsync(StakingContractFunction stakingContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingContractFunction, string>(stakingContractFunction, blockParameter);
        }

        
        public Task<string> StakingContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingContractFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> GetCurrentTimestampQueryAsync(GetCurrentTimestampFunction getCurrentTimestampFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentTimestampFunction, BigInteger>(getCurrentTimestampFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentTimestampQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentTimestampFunction, BigInteger>(null, blockParameter);
        }
    }
}
